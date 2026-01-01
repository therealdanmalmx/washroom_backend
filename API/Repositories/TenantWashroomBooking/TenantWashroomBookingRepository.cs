using Core.Models;

namespace API.Repositories;

public class TenantWashroomBookingRepository : ITenantWashroomBookingRepository
{
    private List<TenantWashroomBooking> _tenantWashroomBookings =
    [
        new TenantWashroomBooking()
        {
            Id = 1,
            Date = DateOnly.FromDateTime(DateTime.Now),
            TenantId = 1,
            WashroomScheduleId = 1
        },
        new TenantWashroomBooking()
        {
            Id = 2,
            Date = DateOnly.FromDateTime(DateTime.Now.AddMonths(+2)),
            TenantId = 2,
            WashroomScheduleId = 2
        }

    ];
    public List<TenantWashroomBooking> GetAllTenantWashroomBooking()
    {
        return _tenantWashroomBookings;
    }

    public List<TenantWashroomBooking> CreateTenantWashroomooking(TenantWashroomBooking tenantWashroomBooking)
    {
        _tenantWashroomBookings.Add(tenantWashroomBooking);
        return _tenantWashroomBookings;
    }

    public TenantWashroomBooking? GetTenantWashroomBookingById(int id)
    {
        var result = _tenantWashroomBookings.FirstOrDefault(x => x.Id == id);
        if (result == null)
        {
            return null;
        }
        return result;
    }

    public List<TenantWashroomBooking>? UpdateTenatWashroomBooking(int id, TenantWashroomBooking tenantWashroomBooking)
    {
        var tenantWashroomBookingToUpdateIndex = _tenantWashroomBookings.FindIndex(x => x.Id == id);
        if (tenantWashroomBookingToUpdateIndex == -1)
        {
            return null;
        }
        _tenantWashroomBookings[tenantWashroomBookingToUpdateIndex] = tenantWashroomBooking;
        return _tenantWashroomBookings;
    }

    public List<TenantWashroomBooking>? DeleteTenantWashroomBookingById(int id)
    {
        var result = _tenantWashroomBookings.FirstOrDefault(x => x.Id == id);
        if (result == null)
        {
            return null;
        }
        _tenantWashroomBookings.Remove(result);
        return _tenantWashroomBookings;
    }
}