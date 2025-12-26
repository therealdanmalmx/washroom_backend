using API.Repositories;
using API.Services;
using Core.Models;
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

        // [HttpGet("{id}")]
        // public ActionResult<PropertyAdministration> GetPropertyAdministration(Guid id)
        // {
        //     return _propertyAdministrationRepository.GetPropertyAdministration(id);
        // }

        [HttpPost]
        public ActionResult<List<PropertyAdministrationGetAllDto>> CreatePropertyAdministration(
            PropertyAdministrationCreateDto newPropertyAdministration)
        {
            _propertyAdministrationService.CreatePropertyAdministration(newPropertyAdministration);
            return Ok(_propertyAdministrationService);
        }

        // [HttpPut("{id}")]
        // public Action<PropertyAdministration> UpdatateProprtyAdministration(Guid id,
        //     PropertyAdministration propertyAdministration)
        // {
        //     PropertyAdministration? paToUpate = _propertyAdministrations.SingleOrDefault(p => p.Id == id);
        //
        //     if (!string.IsNullOrEmpty(paToUpate.Name))
        //     {
        //         paToUpate.Name = propertyAdministration.Name;
        //     }
        //     if (!string.IsNullOrEmpty(paToUpate.Logo))
        //     {
        //         paToUpate.Logo = propertyAdministration.Logo;
        //     }
        //
        //     return some;
        // }
}
}
