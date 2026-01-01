using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Apartment> Apartments { get; set; }
    public DbSet<Association> Associations { get; set; }
    public DbSet<AssociationManager> AssociationManagers { get; set; }
    public DbSet<Property> Properties { get; set; }
    public DbSet<PropertyAdministration> PropertyAdministrations { get; set; }
    public DbSet<PropertyManager> PropertyManagers { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<ScheduleStatus> ScheduleStatuses { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantWashroomBooking> TenantWashroomBookings { get; set; }
    public DbSet<WashRoom> WashRooms { get; set; }
    public DbSet<WashRoomSchedule> WashRoomSchedules { get; set; }
}