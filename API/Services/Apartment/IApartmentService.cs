using Core.DTOs.Apartment;

namespace API.Services.Apartment;

public interface IApartmentService
{
    Task<List<ApartmentGetAllDto>> GetAllApartments();
    Task<List<ApartmentGetAllDto>> CreateApartment(ApartmentCreateDto newApartment);
    Task<ApartmentGetAllDto?> GetApartmentById(Guid id);
    Task<List<ApartmentGetAllDto>>? UpdateApartment(Guid id, ApartmentUpdateDto updatedApartment);
    Task<List<ApartmentGetAllDto>>? DeleteApartment(Guid id);
}