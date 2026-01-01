using API.Data;
using API.Repositories;
using API.Repositories.ScheduleRepository;
using API.Repositories.SheduleStatus;
using API.Services;
using API.Services.Apartment;
using API.Services.Association;
using API.Services.AssociationManager;
using API.Services.Property;
using API.Services.PropertyManager;
using API.Services.Schedule;
using API.Services.Tenant;
using API.Services.TenantWashroomBooking;
using API.Services.WashRoomSchedule;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Add Database Connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DataContext>(options => 
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IPropertyAdministrationRepository, PropertyAdministrationRepository>();
builder.Services.AddScoped<IPropertyAdministrationService, PropertyAdministrationService>();

builder.Services.AddScoped<IPropertyManagerRepository, PropertyManagerRepository>();
builder.Services.AddScoped<IPropertyManagerService, PropertyManagerService>();

builder.Services.AddScoped<IAssociationRepository, AssociationRepository>();
builder.Services.AddScoped<IAssociationService, AssociationService>();

builder.Services.AddScoped<IAssociationManagerRepository, AssociationManagerRepository>();
builder.Services.AddScoped<IAssociationManagerService, AssociationManagerService>();

builder.Services.AddScoped<IPropertyRepository, PropertyRepository>();
builder.Services.AddScoped<IPropertyService, PropertyService>();

builder.Services.AddScoped<IApartmentRepository, ApartmentRepository>();
builder.Services.AddScoped<IApartmentService, ApartmentService>();

builder.Services.AddScoped<ITenantRepository, TenantRepository>();
builder.Services.AddScoped<ITenantService, TenantService>();

builder.Services.AddScoped<IScheduleStatusRepository, ScheduleStatusRepository>();
builder.Services.AddScoped<IScheduleStatusService, ScheduleStatusService>();

builder.Services.AddScoped<IScheduleRepository, ScheduleRepository>();
builder.Services.AddScoped<IScheduleService, ScheduleService>();

builder.Services.AddScoped<IWashoomscheduleRepository, WashroomscheduleRepository>();
builder.Services.AddScoped<IWashroomScheduleService, WashroomScheduleService>();

builder.Services.AddScoped<ITenantWashroomBookingRepository, TenantWashroomBookingRepository>();
builder.Services.AddScoped<ITenantWashroomService, TenantWashroomService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
