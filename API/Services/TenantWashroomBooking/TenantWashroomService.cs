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

    public List<TenantWashroomBookingGetAllDto> GetAllTenantWashroomBooking()
    {
        var result = _tenantWashroomBookingRepository.GetAllTenantWashroomBooking();
        return result.Adapt<List<TenantWashroomBookingGetAllDto>>();
    }

    public List<TenantWashroomBookingGetAllDto> CreateTenantWashroomBookings(TenantWashroomBookingCreateDto newTenantWashroomBooking)
    {
        var newTentantWashroomBookingEntry =  newTenantWashroomBooking.Adapt<Core.Models.TenantWashroomBooking>();
        var result = _tenantWashroomBookingRepository.CreateTenantWashroomooking(newTentantWashroomBookingEntry);
        return result.Adapt<List<TenantWashroomBookingGetAllDto>>();
    }

    public TenantWashroomBookingGetAllDto? GetTenantWashroomBookingById(int id)
    {
        var result = _tenantWashroomBookingRepository.GetTenantWashroomBookingById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<TenantWashroomBookingGetAllDto>();
    }

    public List<TenantWashroomBookingGetAllDto>? UpdateTenatntWashroomBooking(int id, TenantWashroomBookingUpdateDto updateTenantWashroomBooking)
    {
        var tenantWashroomBookingToUpdtae = updateTenantWashroomBooking.Adapt<Core.Models.TenantWashroomBooking>();
        var result = _tenantWashroomBookingRepository.UpdateTenatWashroomBooking(id, tenantWashroomBookingToUpdtae);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<TenantWashroomBookingGetAllDto>>();
    }

    public List<TenantWashroomBookingGetAllDto>? DeleteTenantWashroomBooking(int id)
    {
        var result = _tenantWashroomBookingRepository.DeleteTenantWashroomBookingById(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<TenantWashroomBookingGetAllDto>>();
    }
}