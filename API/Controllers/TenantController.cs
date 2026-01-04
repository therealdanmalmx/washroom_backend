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
        public async Task<ActionResult<List<TenantGetAllDto>>> GetAllTenants()
        {
            return Ok(await _tenantService.GetAllTenants());
        }

        [HttpPost]
        public async Task<ActionResult<List<TenantGetAllDto>>> CreateTenant(TenantCreateDto newTenant)
        {
            return Ok(await _tenantService.CreateTenant(newTenant));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TenantGetAllDto>> GetTenantById(int id)
        {
            var result = await _tenantService.GetTenantById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TenantGetAllDto>> UpdateTenant(int id, TenantUpdateDto updatedTenant)
        {
            var result =  await _tenantService.UpdateTenant(id, updatedTenant);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TenantGetAllDto>>> DeleteTenant(int id)
        {
            var result = await _tenantService.DeleteTenant(id);
            return Ok(result);
        }
    }
}
