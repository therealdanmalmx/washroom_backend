using API.Services.Tenant;
using Core.DTOs.Tenant;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly ITenantRegisterService _tenantRegisterService;
        private readonly ITenantLoginService _tenantLoginService;

        public TenantController(ITenantRegisterService tenantRegisterService, ITenantLoginService tenantLoginService)
        {
            _tenantRegisterService = tenantRegisterService;
            _tenantLoginService = tenantLoginService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TenantRegistrationResponse>>> GetAllParticipants()
        {
            var result = await _tenantRegisterService.GetAllTenants();
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<ActionResult<TenantRegistrationResponse>> RegisterParticipant(
            TenantRegistrationRequest request)
        {
            var result = await _tenantRegisterService.RegisterTenant(request);

            if (!result.IsSuccessful)
            {
                return BadRequest(new TenantRegistrationResponse(false, result.Errors));
            }

            return Ok(new TenantRegistrationResponse(true));
        }
        
        [HttpPost("login")]
        public async Task<ActionResult<TenantLoginResponse>> Login(TenantLoginRequest request)
        {
            var result = await _tenantLoginService.Login(request);

            if (!result.IsSuccessful)
            {
                return new TenantLoginResponse(false, result.Errors);
            }

            return Ok(result);
        }
    }
}