using Core.Models;

namespace API.Repositories;

public interface ITenantWashroomBookingRepository
{
    List<TenantWashroomBooking> GetAllTenantWashroomBooking();
    List<TenantWashroomBooking>CreateTenantWashroomooking(TenantWashroomBooking tenantWashroomBooking);
    TenantWashroomBooking? GetTenantWashroomBookingById(int id);
    List<TenantWashroomBooking>? UpdateTenatWashroomBooking(int id, TenantWashroomBooking tenantWashroomBooking);
    List<TenantWashroomBooking>? DeleteTenantWashroomBookingById(int id);
}