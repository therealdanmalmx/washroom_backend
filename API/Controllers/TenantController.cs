using API.Services.Tenant;
using Core.DTOs.Tenant;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly ITenantService _tenantService;

        public TenantController(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }

        [HttpGet]
        public ActionResult<List<TenantGetAllDto>> GetAllTenants()
        {
            return Ok(_tenantService.GetAllTenants());
        }

        [HttpPost]
        public ActionResult<List<TenantGetAllDto>> CreateTenant(TenantCreateDto newTenant)
        {
            return Ok(_tenantService.CreateTenant(newTenant));
        }

        [HttpGet("{id}")]
        public ActionResult<TenantGetAllDto> GetTenantById(int id)
        {
            var result = _tenantService.GetTenantById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public ActionResult<TenantGetAllDto> UpdateTenant(int id, TenantUpdateDto updatedTenant)
        {
            var result =  _tenantService.UpdateTenant(id, updatedTenant);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<TenantGetAllDto>> DeleteTenant(int id)
        {
            var result = _tenantService.DeleteTenant(id);
            return Ok(result);
        }
    }
}
