using System.Text.Json.Serialization;
using FluentValidation.AspNetCore;
using InteractiveMapProject.API.Email;
using InteractiveMapProject.API.Email_Services;
using InteractiveMapProject.API.Middleware;
using InteractiveMapProject.API.Validators;
using InteractiveMapProject.Common.Profiles;
using InteractiveMapProject.Contracts.Entities;
using InteractiveMapProject.Contracts.Filtering;
using InteractiveMapProject.Contracts.Filtering.FilterProfessional;
using InteractiveMapProject.Contracts.Services;
using InteractiveMapProject.Contracts.Settings;
using InteractiveMapProject.Contracts.UoW;
using InteractiveMapProject.Data.Db.Context;
using InteractiveMapProject.Data.Db.UoW;
using InteractiveMapProject.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static async Task Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("InteractiveMapProjectDb");

        builder.Services.AddDbContext<ApplicationDbContext>(opt =>
        {
            opt.UseSqlServer(connectionString,// change this and connection string to change DB and DBMS
                opt => opt.MigrationsAssembly("InteractiveMapProject.Data.Db")); // How to apply migrations to Data.Db ???
        });

        builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            options.SignIn.RequireConfirmedAccount = true) // Users must confirm their Email
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

        /*builder.Services.Configure<IdentityOptions>(options =>
        {
            // Password settings.
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 1;

            // Lockout settings.
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = true;

            // User settings.
            options.User.AllowedUserNameCharacters =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            options.User.RequireUniqueEmail = true;
        });*/

        //Add email configs
        var emailconfig = builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
        builder.Services.AddSingleton(emailconfig);

        builder.Services.Configure<DataProtectionTokenProviderOptions>(
            options => options.TokenLifespan = TimeSpan.FromHours(2));

        // config for required email
        builder.Services.Configure<IdentityOptions>(
            options => options.SignIn.RequireConfirmedEmail = true
        );


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
            await roleService.CreateAsync("Professional");
            await roleService.CreateAsync("Admin");
            await roleService.CreateAsync("Super-Admin");

        }

        /*using (var scope = app.Services.CreateScope())
        {
            var userService = scope.ServiceProvider.GetRequiredService<IUserService>();
            string adminEmail = "referente_apt31@cocagne31.org";
            string adminPassword = "Apt31@2024";
            await userService.CreateAsync(adminEmail, adminPassword);

            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                var user = new IdentityUser();
                user.UserName = adminEmail;
                user.Email = adminEmail;
                user.EmailConfirmed = true;

                await userManager.CreateAsync(user, adminPassword);

                await userManager.AddToRoleAsync(user, "Super-Admin");
            }

        }*/

        app.Run();

    }
}
