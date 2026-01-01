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
        public ActionResult<List<TenantWashroomBookingGetAllDto>> GetTenantWashroomBooking()
        {
            return Ok(_tenantWashroomService.GetAllTenantWashroomBooking());
        }

        [HttpPost]
        public ActionResult<List<TenantWashroomBookingGetAllDto>> CreateTenantWashroomBooking(
            TenantWashroomBookingCreateDto newTenantWashroomBooking)
        {
            return Ok(_tenantWashroomService.CreateTenantWashroomBookings(newTenantWashroomBooking));
        }

        [HttpGet("{id}")]
        public ActionResult<TenantWashroomBookingGetAllDto>? GetTenantWashroomBookingById(int id)
        {
            var result =  _tenantWashroomService.GetTenantWashroomBookingById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public ActionResult<List<TenantWashroomBookingGetAllDto>>? UpdateTenahtWashroomBooking(int id,
            TenantWashroomBookingUpdateDto updateTenantWashroomBooking)
        {
            var result = _tenantWashroomService.UpdateTenatntWashroomBooking(id, updateTenantWashroomBooking);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<TenantWashroomBookingGetAllDto>>? DeleteTenantWashroomBooking(int id)
        {
            var result = _tenantWashroomService.DeleteTenantWashroomBooking(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
