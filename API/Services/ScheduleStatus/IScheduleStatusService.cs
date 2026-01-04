using Core.DTOs.ScheduleStatus;

namespace API.Services;

public interface IScheduleStatusService
{
    Task<List<ScheduleStatusGetAllDto>> GetAllScheduleStatus();
    Task<List<ScheduleStatusGetAllDto>> CreateScheduleStatus(ScheduleStatusCreateDto newScheduleStatus);
    Task<ScheduleStatusGetAllDto>? GetScheduleStatusById(Guid id);
    Task<List<ScheduleStatusGetAllDto>>? UpdateScheduleStatus(Guid id, ScheduleStatusUpdateDto newScheduleStatus);
    Task<List<ScheduleStatusGetAllDto>>? DeleteScheduleStatus(Guid id);
}