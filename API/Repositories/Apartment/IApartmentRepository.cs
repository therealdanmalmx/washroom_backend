using Core.Models;

namespace API.Repositories;

public interface IApartmentRepository
{
    Task<List<Apartment>> GetAllApartments();
    Task<List<Apartment>> CreateApartment(Apartment newApartment);
    Task<Apartment>? GetApartment(Guid id);
    Task<List<Apartment>>? UpdateApartment(Guid id, Apartment updateApartment);
    Task<List<Apartment>>? DeleteApartment(Guid id);
}