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
        public ActionResult<List<PropertyAdministrationGetAllDto>> GetAllPropertyAdministrations()
        {
            return Ok(_propertyAdministrationService.GetAllPropertyAdministrations());
        }

        [HttpGet("{id}")]
        public ActionResult<PropertyAdministrationGetAllDto> GetPropertyAdministration(int id)
        {
            return Ok(_propertyAdministrationService.GetPropertyAdministration(id));
        }

        [HttpPost]
        public ActionResult<List<PropertyAdministrationGetAllDto>> CreatePropertyAdministration(
            PropertyAdministrationCreateDto newPropertyAdministration)
        {
            _propertyAdministrationService.CreatePropertyAdministration(newPropertyAdministration);
            return Ok(_propertyAdministrationService);
        }

        [HttpPut("{id}")]
        public ActionResult<List<PropertyAdministrationGetAllDto>> UpdatePropertyAdministration(int id,
            PropertyAdministrationUpdateDto updatedPropertyAdministration)
        {
            var result = _propertyAdministrationService.UpdatePropertyAdministration(id, updatedPropertyAdministration);
            if (result == null)
            {
                return NotFound($"Property administration with id: {id} not found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<PropertyAdministrationGetAllDto>> DeletePropertyAdministration(int id)
        {
            var result = _propertyAdministrationService.DeletePropertyAdministration(id);
            if (result == null)
            {
                return NotFound($"Property administration with id: {id} not found");
            }
            return Ok(result);
        }
}
}
