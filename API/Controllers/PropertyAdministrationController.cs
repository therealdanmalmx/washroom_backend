using API.Repositories;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PropertyAdministrationController : ControllerBase
    {
        private readonly IPropertyAdministrationRepository _propertyAdministrationRepository;

        public PropertyAdministrationController(IPropertyAdministrationRepository propertyAdministrationRepository)
        {
            _propertyAdministrationRepository = propertyAdministrationRepository;
        }

        [HttpGet]
        public ActionResult<List<PropertyAdministration>> GetAllPropertyAdministrations()
        {
            return Ok(_propertyAdministrationRepository.GetAllPropertyAdministrations());
        }

        // [HttpGet("{id}")]
        // public ActionResult<PropertyAdministration> GetPropertyAdministration(Guid id)
        // {
        //     return _propertyAdministrationRepository.GetPropertyAdministration(id);
        // }

        [HttpPost]
        public ActionResult<List<PropertyAdministration>> CreatePropertyAdministration(
            PropertyAdministration propertyAdministration)
        {
            _propertyAdministrationRepository.CreatePropertyAdministration(propertyAdministration);
            return Ok(_propertyAdministrationRepository);
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
