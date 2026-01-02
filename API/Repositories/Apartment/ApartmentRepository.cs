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


    public List<Apartment> GetAllApartments()
    {
        return _apartments;
    }

    public async Task<List<Apartment>> CreateApartment(Apartment newApartment)
    {
        _dB.Apartments.Add(newApartment);
        await _dB.SaveChangesAsync();
        return await _dB.Apartments.ToListAsync();
    }

    public Apartment? GetApartment(int id)
    {
        var singleApartment = _apartments.FirstOrDefault(x => x.Id == id);
        if (singleApartment == null)
        {
            return null;
        }
        return singleApartment;
    }

    public List<Apartment>? UpdateApartment(int id, Apartment updateApartment)
    {
        var apartmentToUpdateIndex = _apartments.FindIndex(x => x.Id == id);
        if (apartmentToUpdateIndex == -1)
        {
            return null;
        }
        _apartments[apartmentToUpdateIndex] = updateApartment;
        return _apartments;
    }

    public List<Apartment>? DeleteApartment(int id)
    {
        var result = _apartments.FirstOrDefault(x => x.Id == id);
        if (result == null)
        {
            return null;
        }
        _apartments.Remove(result);
        return _apartments;
    }
}