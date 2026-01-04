using Core.Models;

namespace API.Repositories;

public interface ITenantWashroomBookingRepository
{
    Task<List<TenantWashroomBooking>> GetAllTenantWashroomBooking();
    Task<List<TenantWashroomBooking>>CreateTenantWashroomooking(TenantWashroomBooking tenantWashroomBooking);
    Task<TenantWashroomBooking>? GetTenantWashroomBookingById(Guid id);
    Task<List<TenantWashroomBooking>>? UpdateTenatWashroomBooking(Guid id, TenantWashroomBooking tenantWashroomBooking);
    Task<List<TenantWashroomBooking>>? DeleteTenantWashroomBookingById(Guid id);
}