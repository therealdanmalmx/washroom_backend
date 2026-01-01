using Core.DTOs.ScheduleStatus;

namespace API.Services;

public interface IScheduleStatusService
{
    List<ScheduleStatusGetAllDto> GetAllScheduleStatus();
    List<ScheduleStatusGetAllDto> CreateScheduleStatus(ScheduleStatusCreateDto newScheduleStatus);
    ScheduleStatusGetAllDto? GetScheduleStatusById(int id);
    List<ScheduleStatusGetAllDto>? UpdateScheduleStatus(int id, ScheduleStatusUpdateDto newScheduleStatus);
    List<ScheduleStatusGetAllDto>? DeleteScheduleStatus(int id);
}