using Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : IdentityDbContext<Tenant>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Apartment> Apartments { get; set; }
    public DbSet<Association> Associations { get; set; }
    public DbSet<AssociationManager> AssociationManagers { get; set; }
    public DbSet<Property> Properties { get; set; }
    public DbSet<PropertyAdministration> PropertyAdministrations { get; set; }
    public DbSet<PropertyManager> PropertyManagers { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<ScheduleStatus> ScheduleStatuses { get; set; }
    public DbSet<TenantWashroomBooking> TenantWashroomBookings { get; set; }
    public DbSet<WashRoom> WashRooms { get; set; }
    public DbSet<WashRoomSchedule> WashRoomSchedules { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityPasskeyData>().HasNoKey();

        modelBuilder.Entity<Tenant>()
            .HasMany(t => t.TenantWashroomBookings)
            .WithOne(b => b.Tenant)
            .HasForeignKey(t => t.TenantId);
    }
}



