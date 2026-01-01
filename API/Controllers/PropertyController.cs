using API.Services.Property;
using Core.DTOs.Property;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpGet]
        public ActionResult<List<PropertyGetAllDto>> GetAllProperties()
        {
            return Ok(_propertyService.GetAllProperties());
        }

        [HttpPost]
        public ActionResult<List<PropertyGetAllDto>> CreateProperty(PropertyCreateDto newProperty)
        {
            return Ok(_propertyService.CreateProperty(newProperty));
        }

        [HttpGet("{id}")]
        public ActionResult<PropertyGetAllDto> GetPropertyById(int id)
        {
            return Ok(_propertyService.GetPropertyById(id));
        }

        [HttpPut("{id}")]
        public ActionResult<PropertyGetAllDto> UpdateProperty(int id, PropertyUpdateDto propertyUpdateDto)
        {
            return Ok(_propertyService.UpdateProperty(id, propertyUpdateDto));
        }

        [HttpDelete("{id}")]
        public ActionResult<PropertyGetAllDto> DeleteProperty(int id)
        {
            return Ok(_propertyService.DeleteProperty(id));
        }
        
    }
}
