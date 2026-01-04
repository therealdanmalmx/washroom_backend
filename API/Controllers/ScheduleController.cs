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
        public async Task<ActionResult<List<ScheduleGetAllDto>>> GetAlLSchedules()
        {
            return Ok(await _scheduleService.GetAllSchedules());
        }

        [HttpPost]
        public async Task<ActionResult<List<ScheduleGetAllDto>>> CreateSchedule(ScheduleCreateDto newSchedule)
        {
            return Ok(await _scheduleService.CreateSchedule(newSchedule));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleGetAllDto>>? GetScheduleById(Guid id)
        {
            var result = await _scheduleService.GetScheduleById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ScheduleGetAllDto>>>? UpdateSchedule(Guid id, ScheduleUpdateDto updateSchedule)
        {
            var result = await _scheduleService.UpdateSchedules(id, updateSchedule);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ScheduleGetAllDto>>>? DeleteSchedule(Guid id)
        {
            var result = await _scheduleService.DeleteSchedules(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
