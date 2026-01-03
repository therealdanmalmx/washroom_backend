using Core.DTOs.Apartment;

namespace API.Services.Apartment;

public interface IApartmentService
{
    Task<List<ApartmentGetAllDto>> GetAllApartments();
    Task<List<ApartmentGetAllDto>> CreateApartment(ApartmentCreateDto newApartment);
    Task<ApartmentGetAllDto?> GetApartmentById(int id);
    Task<List<ApartmentGetAllDto>>? UpdateApartment(int id, ApartmentUpdateDto updatedApartment);
    Task<List<ApartmentGetAllDto>>? DeleteApartment(int id);
}