using Core.Models;

namespace API.Repositories;

public interface ITenantWashroomBookingRepository
{
    Task<List<TenantWashroomBooking>> GetAllTenantWashroomBooking();
    Task<List<TenantWashroomBooking>>CreateTenantWashroomooking(TenantWashroomBooking tenantWashroomBooking);
    Task<TenantWashroomBooking>? GetTenantWashroomBookingById(int id);
    Task<List<TenantWashroomBooking>>? UpdateTenatWashroomBooking(int id, TenantWashroomBooking tenantWashroomBooking);
    Task<List<TenantWashroomBooking>>? DeleteTenantWashroomBookingById(int id);
}