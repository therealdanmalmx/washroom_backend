using API.Services;
using Core.DTOs.ScheduleStatus; 
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ScheduleStatusController : ControllerBase
    {
        private readonly IScheduleStatusService _scheduleStatusService;

        public ScheduleStatusController(IScheduleStatusService scheduleStatusService)
        {
            _scheduleStatusService = scheduleStatusService;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<ScheduleStatusGetAllDto>>> GetAllScheduleStatus()
        {
            return Ok(await _scheduleStatusService.GetAllScheduleStatus());
        }

        [HttpPost]
        public async Task<ActionResult<List<ScheduleStatusGetAllDto>>> CreateScheduleStatus(Guid id,
            ScheduleStatusCreateDto newScheduleStatus)
        {
            return Ok(await _scheduleStatusService.CreateScheduleStatus(newScheduleStatus));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleStatusGetAllDto>> GetScheduleStatus(Guid id)
        {
            var result = await _scheduleStatusService.GetScheduleStatusById((id));
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ScheduleStatusGetAllDto>>> UpdateScheduleStatus(Guid id,
            ScheduleStatusUpdateDto newScheduleStatus)
        {
            var result = await _scheduleStatusService.UpdateScheduleStatus(id, newScheduleStatus);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ScheduleStatusGetAllDto>>> DeleteScheduleStatus(Guid id)
        {
            var result = await _scheduleStatusService.DeleteScheduleStatus(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
