using System.Text;
using System.Text.Json.Serialization;
using FluentValidation.AspNetCore;
using InteractiveMapProject.API.Email;
using InteractiveMapProject.API.Email_Services;
using InteractiveMapProject.API.Middleware;
using InteractiveMapProject.API.Utilities;
using InteractiveMapProject.API.Validators;
using InteractiveMapProject.Common.Profiles;
using InteractiveMapProject.Contracts.Dtos;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Filtering;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.Settings;
using InteractiveMapProject.Contracts.UoW;
using InteractiveMapProject.Data.Db.Context;
using InteractiveMapProject.Data.Db.UoW;
using InteractiveMapProject.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

public class Program
{
    public static async Task Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("InteractiveMapProjectDb");

        builder.Services.AddDbContext<ApplicationDbContext>(opt =>
        {
            opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
                    opt => opt.MigrationsAssembly("InteractiveMapProject.Data.Db"));
        });

        builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            options.SignIn.RequireConfirmedAccount = true) // Users must confirm their Email
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

        // Adding Authentication
        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        // Adding Jwt Bearer
        .AddJwtBearer(options =>
        {
            options.SaveToken = true;
            options.RequireHttpsMetadata = false;
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JWT")["Secret"]))
            };
        });

        builder.Services.Configure<IdentityOptions>(options =>
        {
#if !TESTING
            // Password settings.
            options.Password.RequireDigit = true; 
            options.Password.RequireLowercase = true;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 10;
            options.Password.RequiredUniqueChars = 1;

            // Lockout settings. If a user tries to log in 5 times in 5 minutes, he will be locked out for 5 minutes
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = true;

            // User settings.
            options.User.RequireUniqueEmail = true;
#else
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 1;
#endif
        });

        builder.Services.AddAuthorization(options =>
        {
            options.AddPolicy("AdminOrSuperAdmin", policy =>
                policy.RequireRole(UserRoles.SuperAdmin, UserRoles.Admin));
        });
        builder.Services.AddAuthorization(options =>
        {
            options.AddPolicy("ProfessionalOrAdminOrSuperAdmin", policy =>
                policy.RequireRole(UserRoles.Professional, UserRoles.Admin, UserRoles.SuperAdmin));
        });

        //Add email configs
        var emailconfig = builder.Configuration.GetSection("Brevo").Get<EmailConfiguration>();
        builder.Services.AddSingleton(emailconfig);


        // config for required email
        builder.Services.Configure<IdentityOptions>(
            options => options.SignIn.RequireConfirmedEmail = true
        );
        builder.Services.Configure<DataProtectionTokenProviderOptions>(
            options => options.TokenLifespan = TimeSpan.FromHours(2));

        builder.Services
            .AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true)
            .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()))
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ProfessionalRequestDtoValidator>())
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ProfessionalFilterRequestValidator>());

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddAutoMapper(cfg =>
        {
            cfg.AddProfile<MappingProfile>();
        }, AppDomain.CurrentDomain.GetAssemblies());

        builder.Services.Configure<GeoapifySettings>(builder.Configuration.GetSection("Geoapify"));

        builder.Services.AddScoped<IFilterFactory<Professional, ProfessionalFilterRequest>, ProfessionalFilterFactory>();

        builder.Services.AddHttpClient();

        builder.Services.AddScoped<IHttpService, HttpService>();
        builder.Services.AddScoped<IGeocodingService, GeoapifyGeocodingService>();
        builder.Services.AddScoped<IProfessionalService, ProfessionalService>();
        builder.Services.AddScoped<IPendingProfessionalService, PendingProfessionalService>();
        builder.Services.AddScoped<IAudienceService, AudienceService>();
        builder.Services.AddScoped<IPlaceOfInterventionService, PlaceOfInterventionService>();
        builder.Services.AddScoped<IMissionService, MissionService>();
        builder.Services.AddScoped<IValidationStatusService, ValidationStatusService>();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<IRoleService, RoleService>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IEmailService, EmailService>();
        builder.Services.AddScoped<ITokenGeneratorService, TokenGeneratorService>();

        var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: MyAllowSpecificOrigins,
                policy =>
                {
                    policy.WithOrigins("http://localhost:3000")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
        });


        var app = builder.Build();


        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }


        app.UseCors(MyAllowSpecificOrigins);

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();


        app.UseMiddleware<ExceptionHandlerMiddleware>();

        app.MapControllers();

        using (var scope = app.Services.CreateScope())
        {
            var roleService = scope.ServiceProvider.GetRequiredService<IRoleService>();
            await roleService.CreateAsync(UserRoles.Professional);
            await roleService.CreateAsync(UserRoles.Admin);
            await roleService.CreateAsync(UserRoles.SuperAdmin);
        }

#if TESTING
        using (var scope = app.Services.CreateScope())
        {
            var userService = scope.ServiceProvider.GetRequiredService<IUserService>();

            string adminEmail = "admin@admin";
            string adminPassword = "admin123";
            if (await userService.GetByEmailAsync(adminEmail) == null)
            {
                await userService.CreateAsync(adminEmail, adminPassword);
                await userService.AddToRoleAsync(adminEmail, UserRoles.Admin);
            }

            string professionalEmail = "test@test";
            string professionalPassword = "test123";
            Guid proId = Guid.Parse("b2c28b3c-066e-4b7c-6ec8-08dc70315fd2");
            if (await userService.GetByEmailAsync(professionalEmail) == null)
            {
                await userService.CreateAsync(professionalEmail, professionalPassword, proId);
                await userService.AddToRoleAsync(professionalEmail, UserRoles.Professional);
            }
        }
#else
        using (var scope = app.Services.CreateScope())
        {
            var userService = scope.ServiceProvider.GetRequiredService<IUserService>();
            // Replace with your credentials 
            string adminEmail = "";
            string adminPassword = "";
            if (await userService.GetByEmailAsync(adminEmail) == null)
            { // Uncomment these lines
                //await userService.CreateAsync(adminEmail, adminPassword);
                //await userService.AddToRoleAsync(adminEmail, UserRoles.Admin);
            }
        }
#endif
        app.Run();

    }
}
