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
    }
}
