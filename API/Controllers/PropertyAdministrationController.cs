using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PropertyAdministrationController : ControllerBase
    {
        private static List<PropertyAdministration> _propertyAdministrations =
        [
            new PropertyAdministration
            {
                Id = Guid.NewGuid(),
                Name = "HSB",
                Logo = "https://www.hsb.se/contentassets/2ba369972d73485598f9c965076774cc/logo_apsis.jpg",
                CreatedAt = DateTime.Now,
            },
            new PropertyAdministration
            {
                Id = Guid.NewGuid(),
                Name = "Riksbyggen",
                Logo =
                    "https://mnd-assets.mynewsdesk.com/image/upload/c_fill,dpr_auto,f_auto,g_xy_center,q_auto:good,w_1782,x_299,y_207/0wwly1zv6uf8oro3hq4sj6",
                CreatedAt = DateTime.Now,
            },
        ];

        [HttpGet]
        public ActionResult<List<PropertyAdministration>> GetAllPropertyAdministrations()
        {
            return Ok(_propertyAdministrations);
        }

        [HttpGet("{id}")]
        public ActionResult<PropertyAdministration> GetPropertyAdministration(Guid id)
        {
            return _propertyAdministrations.SingleOrDefault(p => p.Id == id);
        }

        [HttpPost]
        public ActionResult<List<PropertyAdministration>> CreatePropertyAdministration(
            PropertyAdministration propertyAdministration)
        {
            _propertyAdministrations.Add(propertyAdministration);
            return Ok(_propertyAdministrations);
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
