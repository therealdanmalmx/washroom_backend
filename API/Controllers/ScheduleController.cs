using API.Services.Schedule;
using Core.DTOs.Schedule;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet]
        public ActionResult<List<ScheduleGetAllDto>> GetAlLSchedules()
        {
            return Ok(_scheduleService.GetAllSchedules());
        }

        [HttpPost]
        public ActionResult<List<ScheduleGetAllDto>> CreateSchedule(ScheduleCreateDto newSchedule)
        {
            return Ok(_scheduleService.CreateSchedule(newSchedule));
        }

        [HttpGet("{id}")]
        public ActionResult<ScheduleGetAllDto>? GetScheduleById(int id)
        {
            var result = _scheduleService.GetScheduleById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public ActionResult<List<ScheduleGetAllDto>>? UpdateSchedule(int id, ScheduleUpdateDto updateSchedule)
        {
            var result = _scheduleService.UpdateSchedules(id, updateSchedule);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<ScheduleGetAllDto>>? DeleteSchedule(int id)
        {
            var result = _scheduleService.DeleteSchedules(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
