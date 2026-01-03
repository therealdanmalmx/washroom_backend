using API.Repositories;
using Core.DTOs.Apartment;
using Mapster;

namespace API.Services.Apartment;

public class ApartmentService : IApartmentService
{
    public readonly IApartmentRepository _apartmentRepository;
    public ApartmentService(IApartmentRepository apartmentRepository)
    {
        _apartmentRepository = apartmentRepository;
    }

    public async Task<List<ApartmentGetAllDto>> GetAllApartments()
    {
        var result =await _apartmentRepository.GetAllApartments();
        return result.Adapt<List<ApartmentGetAllDto>>();
    }

    public async Task<List<ApartmentGetAllDto>> CreateApartment(ApartmentCreateDto newApartment)
    {
        var newApartmentEntry = newApartment.Adapt<Core.Models.Apartment>();
        var result = await _apartmentRepository.CreateApartment(newApartmentEntry);
        newApartmentEntry.CreatedAt = DateTime.UtcNow;
        if (result is null)
        {
            return null;
        }
        return result.Adapt<List<ApartmentGetAllDto>>();
    }

    public async Task<ApartmentGetAllDto?> GetApartmentById(int id)
    {
        var  result = await _apartmentRepository.GetApartment(id);
        return result.Adapt<ApartmentGetAllDto>();
    }

    public async Task<List<ApartmentGetAllDto>>? UpdateApartment(int id, ApartmentUpdateDto updatedApartment)
    {
        var apartmentUpdate = updatedApartment.Adapt<Core.Models.Apartment>();
        var result = _apartmentRepository.UpdateApartment(id, apartmentUpdate);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<ApartmentGetAllDto>>();
    }

    public async Task<List<ApartmentGetAllDto>>? DeleteApartment(int id)
    {
        var result = await _apartmentRepository.DeleteApartment(id);
        if (result == null)
        {
            return null;
        }
        return result.Adapt<List<ApartmentGetAllDto>>();
    }
}