using Core.DTOs.Apartment;

namespace API.Services.Apartment;

public interface IApartmentService
{
    List<ApartmentGetAllDto> GetAllApartments();
    Task<List<ApartmentGetAllDto>> CreateApartment(ApartmentCreateDto newApartment);
    ApartmentGetAllDto? GetApartmentById(int id);
    List<ApartmentGetAllDto>? UpdateApartment(int id, ApartmentUpdateDto updatedApartment);
    List<ApartmentGetAllDto>? DeleteApartment(int id);
}