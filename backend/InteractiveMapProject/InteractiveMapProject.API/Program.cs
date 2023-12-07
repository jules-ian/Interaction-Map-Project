using System.Text.Json.Serialization;
using FluentValidation.AspNetCore;
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
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("InteractiveMapProjectDb"),
        opt => opt.MigrationsAssembly("InteractiveMapProject.Data.Db"));
});

builder.Services
    .AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true)
    .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()))
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<ProfessionalRequestDtoValidator>());

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
builder.Services.AddScoped<IAudienceService, AudienceService>();
builder.Services.AddScoped<IPlaceOfInterventionService, PlaceOfInterventionService>();
builder.Services.AddScoped<IMissionService, MissionService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          // TODO 
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

app.UseAuthorization();



app.UseMiddleware<ExceptionHandlerMiddleware>();

app.MapControllers();

app.Run();
