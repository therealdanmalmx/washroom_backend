using API.Services.PropertyManager;
using Core.DTOs.PropertyManager;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PropertyManagerController : ControllerBase
    {
        private readonly IPropertyManagerService _propertyManagerService;

        public PropertyManagerController(IPropertyManagerService propertyManagerService)
        {
            _propertyManagerService = propertyManagerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PropertyManagerGetAllDto>>> GetAllPropertyManagers()
        {
            return Ok(await _propertyManagerService.GetAllPropertyManagers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyManagerGetAllDto>> GetPropertyManagerById(int id)
        {
            return Ok(await _propertyManagerService.GetPropertyManagerById(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<PropertyManagerGetAllDto>>> CreatePropertyManager(
            PropertyManagerCreateDto newPropertyManager)
        {
            return Ok(await _propertyManagerService.CreatePropertyManager(newPropertyManager));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<PropertyManagerGetAllDto>>> UpdatePropertyManager(int id,
            PropertyManagerUpdateDto updatePropertyManager)
        {
            return Ok(await _propertyManagerService.UpdatePropertyManager(id, updatePropertyManager));
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<PropertyManagerGetAllDto>>> DeletePropertyManager(int id)
        {
            var result = await _propertyManagerService.DeletePropertyManager(id);
            if (result == null)
            {
                return NotFound($"Property manager with id: {id} not found");
            }
            return Ok(result);
        }
    }
}
