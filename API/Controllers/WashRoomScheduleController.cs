using API.Services.WashRoomSchedule;
using Core.DTOs.WasroomSchedule;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class WashRoomScheduleController : ControllerBase
    {
        private readonly IWashroomScheduleService _washroomScheduleService;

        public WashRoomScheduleController(IWashroomScheduleService washroomScheduleService)
        {
            _washroomScheduleService = washroomScheduleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<WashRoomScheduleGetAllDto>>> GetAllWashRoomSchedule()
        {
            return Ok(await _washroomScheduleService.GetAllWashRoomSchedules());
        }

        [HttpPost]
        public async Task<ActionResult<List<WashRoomScheduleGetAllDto>>> CreateWashroomSchedule(
            WashRoomScheduleCreateDto newWashRoomSchedule)
        {
            return Ok(await _washroomScheduleService.CreateWashRoomSchedules(newWashRoomSchedule));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WashRoomScheduleGetAllDto>> GetWashRoomSchedule(int id)
        {
            var result = await _washroomScheduleService.GetWashRoomScheduleById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<WashRoomScheduleGetAllDto>>> UpdateWashroomSchedule(int id,
            WashRoomScheduleUpdateDto newWashRoomSchedule)
        {
            var result = await _washroomScheduleService.GetWashRoomScheduleById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<WashRoomScheduleGetAllDto>>> DeleteWashroomSchedule(int id)
        {
            var result = await _washroomScheduleService.DeleteWashRoomSchedules(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
