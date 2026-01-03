using API.Data;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class ApartmentRepository : IApartmentRepository
{
    private readonly DataContext _dB;
    public ApartmentRepository(DataContext dB)
    {
        _dB = dB;
    }
    private List<Apartment> _apartments =
    [
        new Apartment()
        {
            Id = 1,
            Number = "1101",
            PropertyId = 1,
        },
        new Apartment()
        {
            Id = 2,
            Number = "1201",
            PropertyId = 2,
        }
    ];


    public async Task<List<Apartment>> GetAllApartments()
    {
        return await _dB.Apartments.ToListAsync();
    }

    public async Task<List<Apartment>> CreateApartment(Apartment newApartment)
    {
        _dB.Apartments.Add(newApartment);
        await _dB.SaveChangesAsync();
        return await _dB.Apartments.ToListAsync();
    }

    public async Task<Apartment>? GetApartment(int id)
    {
        var singleApartment = await _dB.Apartments.FindAsync(id);
        if (singleApartment == null)
        {
            return null;
        }
        return singleApartment;
    }

    public async Task<List<Apartment>>? UpdateApartment(int id, Apartment updateApartment)
    {
        var dBApartmentEntry = await _dB.Apartments.FindAsync(id);

        if (dBApartmentEntry == null)
        {
            return null;
        }

        if (!string.IsNullOrEmpty(updateApartment.Number))
        {
            dBApartmentEntry.Number = updateApartment.Number;
        }
        
        await _dB.SaveChangesAsync();
        return await _dB.Apartments.ToListAsync();
    }

    public async Task<List<Apartment>>? DeleteApartment(int id)
    {
        var result = await _dB.Apartments.FindAsync(id);
        if (result == null)
        {
            return null;
        }
        _dB.Apartments.Remove(result);
        await _dB.SaveChangesAsync();
        return await _dB.Apartments.ToListAsync();
    }
}