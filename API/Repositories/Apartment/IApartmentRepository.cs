using Core.Models;

namespace API.Repositories;

public interface IApartmentRepository
{
    List<Apartment> GetAllApartments();
    List<Apartment> CreateApartment(Apartment newApartment);
    Apartment? GetApartment(int id);
    List<Apartment>? UpdateApartment(int id, Apartment updateApartment);
    List<Apartment>? DeleteApartment(int id);
}