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
        public ActionResult<List<PropertyManagerGetAllDto>> GetAllPropertyManagers()
        {
            return Ok(_propertyManagerService.GetAllPropertyManagers());
        }

        [HttpGet("{id}")]
        public ActionResult<PropertyManagerGetAllDto> GetPropertyManagerById(int id)
        {
            return Ok(_propertyManagerService.GetPropertyManagerById(id));
        }

        [HttpPost]
        public ActionResult<List<PropertyManagerGetAllDto>> CreatePropertyManager(
            PropertyManagerCreateDto newPropertyManager)
        {
            return Ok(_propertyManagerService.CreatePropertyManager(newPropertyManager));
        }

        [HttpPut("{id}")]
        public ActionResult<List<PropertyManagerGetAllDto>> UpdatePropertyManager(int id,
            PropertyManagerUpdateDto updatePropertyManager)
        {
            return Ok(_propertyManagerService.UpdatePropertyManager(id, updatePropertyManager));
        }
        
        [HttpDelete("{id}")]
        public ActionResult<List<PropertyManagerGetAllDto>> DeletePropertyManager(int id)
        {
            var result = _propertyManagerService.DeletePropertyManager(id);
            if (result == null)
            {
                return NotFound($"Property manager with id: {id} not found");
            }
            return Ok(result);
        }
    }
}
