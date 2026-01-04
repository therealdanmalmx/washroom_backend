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
        public async Task<ActionResult<List<PropertyGetAllDto>>> GetAllProperties()
        {
            return Ok(await _propertyService.GetAllProperties());
        }

        [HttpPost]
        public async Task<ActionResult<List<PropertyGetAllDto>>> CreateProperty(PropertyCreateDto newProperty)
        {
            return Ok(await _propertyService.CreateProperty(newProperty));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyGetAllDto>> GetPropertyById(Guid id)
        {
            return Ok(await _propertyService.GetPropertyById(id));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PropertyGetAllDto>> UpdateProperty(Guid id, PropertyUpdateDto propertyUpdateDto)
        {
            return Ok(await _propertyService.UpdateProperty(id, propertyUpdateDto));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PropertyGetAllDto>> DeleteProperty(Guid id)
        {
            return Ok(await _propertyService.DeleteProperty(id));
        }
        
    }
}
