using API.Repositories;
using API.Services.TenantWashroomBooking;
using Core.DTOs.TenantWashroomBooking;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TenantWashroomBookingController : ControllerBase
    {
        private readonly ITenantWashroomService _tenantWashroomService;

        public TenantWashroomBookingController(ITenantWashroomService tenantWashroomService)
        {
            _tenantWashroomService = tenantWashroomService;
        }


        [HttpGet]
        public async Task<ActionResult<List<TenantWashroomBookingGetAllDto>>> GetTenantWashroomBooking()
        {
            return Ok(await _tenantWashroomService.GetAllTenantWashroomBooking());
        }

        [HttpPost]
        public async Task<ActionResult<List<TenantWashroomBookingGetAllDto>>> CreateTenantWashroomBooking(
            TenantWashroomBookingCreateDto newTenantWashroomBooking)
        {
            return Ok(await _tenantWashroomService.CreateTenantWashroomBookings(newTenantWashroomBooking));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TenantWashroomBookingGetAllDto>>? GetTenantWashroomBookingById(Guid id)
        {
            var result =  await _tenantWashroomService.GetTenantWashroomBookingById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<TenantWashroomBookingGetAllDto>>>? UpdateTenahtWashroomBooking(Guid id,
            TenantWashroomBookingUpdateDto updateTenantWashroomBooking)
        {
            var result = await _tenantWashroomService.UpdateTenatntWashroomBooking(id, updateTenantWashroomBooking);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<TenantWashroomBookingGetAllDto>>>? DeleteTenantWashroomBooking(Guid id)
        {
            var result = await _tenantWashroomService.DeleteTenantWashroomBooking(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
