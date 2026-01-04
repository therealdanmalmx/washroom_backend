using Core.DTOs.TenantWashroomBooking;

namespace API.Services.TenantWashroomBooking;

public interface ITenantWashroomService
{
    Task<List<TenantWashroomBookingGetAllDto>> GetAllTenantWashroomBooking();
    Task<List<TenantWashroomBookingGetAllDto>> CreateTenantWashroomBookings(TenantWashroomBookingCreateDto newTenantWashroomBooking);
    Task<TenantWashroomBookingGetAllDto>? GetTenantWashroomBookingById(Guid id);
    Task<List<TenantWashroomBookingGetAllDto>>? UpdateTenatntWashroomBooking(Guid id, TenantWashroomBookingUpdateDto updateTenantWashroomBooking);
    Task<List<TenantWashroomBookingGetAllDto>>? DeleteTenantWashroomBooking(Guid id);
    
}