using Core.Models;

namespace API.Repositories;

public interface IApartmentRepository
{
    Task<List<Apartment>> GetAllApartments();
    Task<List<Apartment>> CreateApartment(Apartment newApartment);
    Task<Apartment>? GetApartment(int id);
    Task<List<Apartment>>? UpdateApartment(int id, Apartment updateApartment);
    Task<List<Apartment>>? DeleteApartment(int id);
}