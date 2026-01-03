using API.Services.Apartment;
using Core.DTOs.Apartment;
using Core.DTOs.Property;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentService _apartmentService;

        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ApartmentGetAllDto>>> GetAllApartments()
        {
            return Ok(await _apartmentService.GetAllApartments());
        }

        [HttpPost]
        public async Task<ActionResult<ApartmentGetAllDto>> CreateApartment(ApartmentCreateDto newApartment)
        {
            return Ok(await _apartmentService.CreateApartment(newApartment));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyGetAllDto>> GetPropertyById(int id)
        {
            var result = await _apartmentService.GetApartmentById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ApartmentGetAllDto>>> UpdateProperty(int id, ApartmentUpdateDto propertyUpdateDto)
        {
            var result = await _apartmentService.UpdateApartment(id, propertyUpdateDto)!;
            if (result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ApartmentGetAllDto>>> DeleteApartment(int id)
        {
            var result = await _apartmentService.DeleteApartment(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
