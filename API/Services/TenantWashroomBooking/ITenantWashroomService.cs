using Core.DTOs.TenantWashroomBooking;

namespace API.Services.TenantWashroomBooking;

public interface ITenantWashroomService
{
    List<TenantWashroomBookingGetAllDto> GetAllTenantWashroomBooking();
    List<TenantWashroomBookingGetAllDto> CreateTenantWashroomBookings(TenantWashroomBookingCreateDto newTenantWashroomBooking);
    TenantWashroomBookingGetAllDto? GetTenantWashroomBookingById(int id);
    List<TenantWashroomBookingGetAllDto>? UpdateTenatntWashroomBooking(int id, TenantWashroomBookingUpdateDto updateTenantWashroomBooking);
    List<TenantWashroomBookingGetAllDto>? DeleteTenantWashroomBooking(int id);
    
}