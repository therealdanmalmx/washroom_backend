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
        public async Task<ActionResult<IEnumerable<TenantRegistrationResponse>>> GetAllParticipants()
        {
            var result = await _tenantService.GetAllTenants();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<TenantRegistrationResponse>> RegisterParticipant(
            TenantRegistrationRequest request)
        {
            var result = await _tenantService.RegisterTenant(request);

            if (!result.IsSuccessful)
            {
                return BadRequest(new TenantRegistrationResponse(false, result.Errors));
            }

            return Ok(new TenantRegistrationResponse(true));
        }
    }
}