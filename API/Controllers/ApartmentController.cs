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
        public ActionResult<List<ApartmentGetAllDto>> GetAllApartments()
        {
            return Ok(_apartmentService.GetAllApartments());
        }

        [HttpPost]
        public ActionResult<ApartmentCreateDto> CreateApartment(ApartmentCreateDto newApartment)
        {
            return Ok(_apartmentService.CreateApartment(newApartment));
        }

        [HttpGet("{id}")]
        public ActionResult<PropertyGetAllDto> GetPropertyById(int id)
        {
            var result = _apartmentService.GetApartmentById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public ActionResult<ApartmentGetAllDto> UpdateProperty(int id, ApartmentUpdateDto propertyUpdateDto)
        {
            var result = _apartmentService.UpdateApartment(id, propertyUpdateDto);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<ApartmentGetAllDto>> DeleteApartment(int id)
        {
            var result = _apartmentService.DeleteApartment(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
