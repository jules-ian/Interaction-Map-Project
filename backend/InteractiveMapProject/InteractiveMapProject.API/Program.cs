using System.Text.Json.Serialization;
using FluentValidation.AspNetCore;
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

        builder.Services.Configure<IdentityOptions>(options =>
        {
            // Password settings.
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 1;
/*
            // Lockout settings.
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = true;

            // User settings.
            options.User.AllowedUserNameCharacters =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            options.User.RequireUniqueEmail = true;*/
        });

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

        using (var scope = app.Services.CreateScope())
        {
            var userService = scope.ServiceProvider.GetRequiredService<IUserService>();

            string adminEmail = "admin@admin.fr";
            string adminPassword = "password";
            if(await userService.GetAsync(adminEmail) == null)
            {
                await userService.CreateAsync(adminEmail, adminPassword);
                await userService.AddToRoleAsync(adminEmail, UserRoles.SuperAdmin);
            }

            string professionalEmail = "pro@pro.fr";
            string professionalPassword = "password";
            if (await userService.GetAsync(professionalEmail) == null)
            {
                await userService.CreateAsync(professionalEmail, professionalPassword);
                await userService.AddToRoleAsync(professionalEmail, UserRoles.Professional);
            }
        }

        app.Run();

    }
}
