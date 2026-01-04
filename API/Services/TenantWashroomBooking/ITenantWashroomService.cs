using Core.DTOs.TenantWashroomBooking;

namespace API.Services.TenantWashroomBooking;

public interface ITenantWashroomService
{
    Task<List<TenantWashroomBookingGetAllDto>> GetAllTenantWashroomBooking();
    Task<List<TenantWashroomBookingGetAllDto>> CreateTenantWashroomBookings(TenantWashroomBookingCreateDto newTenantWashroomBooking);
    Task<TenantWashroomBookingGetAllDto>? GetTenantWashroomBookingById(int id);
    Task<List<TenantWashroomBookingGetAllDto>>? UpdateTenatntWashroomBooking(int id, TenantWashroomBookingUpdateDto updateTenantWashroomBooking);
    Task<List<TenantWashroomBookingGetAllDto>>? DeleteTenantWashroomBooking(int id);
    
}