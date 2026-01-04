using API.Repositories;
using Core.DTOs.TenantWashroomBooking;
using Mapster;

namespace API.Services.TenantWashroomBooking;

public class TenantWashroomService : ITenantWashroomService
{
    private readonly ITenantWashroomBookingRepository _tenantWashroomBookingRepository;

    public TenantWashroomService(ITenantWashroomBookingRepository tenantWashroomBookingRepository)
    {
        _tenantWashroomBookingRepository = tenantWashroomBookingRepository;
    }

    public async Task<List<TenantWashroomBookingGetAllDto>> GetAllTenantWashroomBooking()
    {
        var result = await _tenantWashroomBookingRepository.GetAllTenantWashroomBooking();
        return result.Adapt<List<TenantWashroomBookingGetAllDto>>();
    }

    public async Task<List<TenantWashroomBookingGetAllDto>> CreateTenantWashroomBookings(TenantWashroomBookingCreateDto newTenantWashroomBooking)
    {
        var newTentantWashroomBookingEntry =  newTenantWashroomBooking.Adapt<Core.Models.TenantWashroomBooking>();
        var result = await _tenantWashroomBookingRepository.CreateTenantWashroomooking(newTentantWashroomBookingEntry);
        return result.Adapt<List<TenantWashroomBookingGetAllDto>>();
    }

    public async Task<TenantWashroomBookingGetAllDto>? GetTenantWashroomBookingById(Guid id)
    {
        var result = await _tenantWashroomBookingRepository.GetTenantWashroomBookingById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<TenantWashroomBookingGetAllDto>();
    }

    public async Task<List<TenantWashroomBookingGetAllDto>>? UpdateTenatntWashroomBooking(Guid id, TenantWashroomBookingUpdateDto updateTenantWashroomBooking)
    {
        var tenantWashroomBookingToUpdtae = updateTenantWashroomBooking.Adapt<Core.Models.TenantWashroomBooking>();
        var result = await _tenantWashroomBookingRepository.UpdateTenatWashroomBooking(id, tenantWashroomBookingToUpdtae);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<TenantWashroomBookingGetAllDto>>();
    }

    public async Task<List<TenantWashroomBookingGetAllDto>>? DeleteTenantWashroomBooking(Guid id)
    {
        var result = await _tenantWashroomBookingRepository.DeleteTenantWashroomBookingById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<TenantWashroomBookingGetAllDto>>();
    }
}