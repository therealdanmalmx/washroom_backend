using Core.DTOs.Schedule;

namespace API.Services.Schedule;

public interface IScheduleService
{
    Task<List<ScheduleGetAllDto>> GetAllSchedules();
    Task<List<ScheduleGetAllDto>> CreateSchedule(ScheduleCreateDto newSchedule);
    Task<ScheduleGetAllDto>? GetScheduleById(Guid id);
    Task<List<ScheduleGetAllDto>>? UpdateSchedules(Guid id, ScheduleUpdateDto updateSchedule);
    Task<List<ScheduleGetAllDto>>? DeleteSchedules(Guid id);
}