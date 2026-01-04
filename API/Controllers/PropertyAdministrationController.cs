using API.Services;
using Core.DTOs.PropertyAdministration;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PropertyAdministrationController : ControllerBase
    {
        private readonly IPropertyAdministrationService _propertyAdministrationService;

        public PropertyAdministrationController(IPropertyAdministrationService propertyAdministrationService)
        {
            _propertyAdministrationService = propertyAdministrationService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PropertyAdministrationGetAllDto>>> GetAllPropertyAdministrations()
        {
            return Ok(await _propertyAdministrationService.GetAllPropertyAdministrations());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyAdministrationGetAllDto>> GetPropertyAdministration(Guid id)
        {
            return Ok(await _propertyAdministrationService.GetPropertyAdministration(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<PropertyAdministrationGetAllDto>>> CreatePropertyAdministration(
            PropertyAdministrationCreateDto newPropertyAdministration)
        {
            await _propertyAdministrationService.CreatePropertyAdministration(newPropertyAdministration);
            return Ok(_propertyAdministrationService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<PropertyAdministrationGetAllDto>>> UpdatePropertyAdministration(Guid id,
            PropertyAdministrationUpdateDto updatedPropertyAdministration)
        {
            var result = await _propertyAdministrationService.UpdatePropertyAdministration(id, updatedPropertyAdministration);
            if (result == null)
            {
                return NotFound($"Property administration with id: {id} not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<PropertyAdministrationGetAllDto>>> DeletePropertyAdministration(Guid id)
        {
            var result = await _propertyAdministrationService.DeletePropertyAdministration(id);
            if (result == null)
            {
                return NotFound($"Property administration with id: {id} not found");
            }
            return Ok(result);
        }
}
}
