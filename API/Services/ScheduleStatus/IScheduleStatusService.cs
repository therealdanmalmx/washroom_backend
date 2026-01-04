using Core.DTOs.ScheduleStatus;

namespace API.Services;

public interface IScheduleStatusService
{
    Task<List<ScheduleStatusGetAllDto>> GetAllScheduleStatus();
    Task<List<ScheduleStatusGetAllDto>> CreateScheduleStatus(ScheduleStatusCreateDto newScheduleStatus);
    Task<ScheduleStatusGetAllDto>? GetScheduleStatusById(int id);
    Task<List<ScheduleStatusGetAllDto>>? UpdateScheduleStatus(int id, ScheduleStatusUpdateDto newScheduleStatus);
    Task<List<ScheduleStatusGetAllDto>>? DeleteScheduleStatus(int id);
}