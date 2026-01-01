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
        public ActionResult<List<WashRoomScheduleGetAllDto>> GetAllWashRoomSchedule()
        {
            return Ok(_washroomScheduleService.GetAllWashRoomSchedules());
        }

        [HttpPost]
        public ActionResult<List<WashRoomScheduleGetAllDto>> CreateWashroomSchedule(
            WashRoomScheduleCreateDto newWashRoomSchedule)
        {
            return Ok(_washroomScheduleService.CreateWashRoomSchedules(newWashRoomSchedule));
        }

        [HttpGet("{id}")]
        public ActionResult<WashRoomScheduleGetAllDto> GetWashRoomSchedule(int id)
        {
            var result = _washroomScheduleService.GetWashRoomScheduleById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public ActionResult<List<WashRoomScheduleGetAllDto>> UpdateWashroomSchedule(int id,
            WashRoomScheduleUpdateDto newWashRoomSchedule)
        {
            var result =  _washroomScheduleService.GetWashRoomScheduleById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<WashRoomScheduleGetAllDto>> DeleteWashroomSchedule(int id)
        {
            var result = _washroomScheduleService.DeleteWashRoomSchedules(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
