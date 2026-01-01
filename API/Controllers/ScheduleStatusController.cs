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
        public ActionResult<List<ScheduleStatusGetAllDto>> GetAllScheduleStatus()
        {
            return Ok(_scheduleStatusService.GetAllScheduleStatus());
        }

        [HttpPost]
        public ActionResult<List<ScheduleStatusGetAllDto>> CreateScheduleStatus(int id,
            ScheduleStatusCreateDto newScheduleStatus)
        {
            return Ok(_scheduleStatusService.CreateScheduleStatus(newScheduleStatus));
        }

        [HttpGet("{id}")]
        public ActionResult<ScheduleStatusGetAllDto> GetScheduleStatus(int id)
        {
            var result = _scheduleStatusService.GetScheduleStatusById((id));
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public ActionResult<List<ScheduleStatusGetAllDto>> UpdateScheduleStatus(int id,
            ScheduleStatusUpdateDto newScheduleStatus)
        {
            var result = _scheduleStatusService.UpdateScheduleStatus(id, newScheduleStatus);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<ScheduleStatusGetAllDto>> DeleteScheduleStatus(int id)
        {
            var result = _scheduleStatusService.DeleteScheduleStatus(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
