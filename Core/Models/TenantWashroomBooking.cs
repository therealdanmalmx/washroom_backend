using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Core.Models;

public class TenantWashroomBooking
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public DateOnly Date { get; set; }
    [StringLength(36)]
    public string? TenantId { get; set; }
    public Tenant? Tenant { get; set; }
    public Guid WashroomScheduleId { get; set; }
    public WashRoomSchedule WashRoomSchedule { get; set; } = new();
    public DateTime CreatedAt { get; set; } =  DateTime.UtcNow;
}