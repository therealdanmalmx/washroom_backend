using API.Repositories;
using API.Services;
using API.Services.Association;
using API.Services.AssociationManager;
using API.Services.PropertyManager;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IPropertyAdministrationRepository, PropertyAdministrationRepository>();
builder.Services.AddScoped<IPropertyAdministrationService, PropertyAdministrationService>();

builder.Services.AddScoped<IPropertyManagerRepository, PropertyManagerRepository>();
builder.Services.AddScoped<IPropertyManagerService, PropertyManagerService>();

builder.Services.AddScoped<IAssociationRepository, AssociationRepository>();
builder.Services.AddScoped<IAssociationService, AssociationService>();

builder.Services.AddScoped<IAssociationManagerRepository, AssociationManagerRepository>();
builder.Services.AddScoped<IAssociationManagerService, AssociationManagerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
