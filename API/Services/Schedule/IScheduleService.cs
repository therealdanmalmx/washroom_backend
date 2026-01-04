using Core.DTOs.Schedule;

namespace API.Services.Schedule;

public interface IScheduleService
{
    Task<List<ScheduleGetAllDto>> GetAllSchedules();
    Task<List<ScheduleGetAllDto>> CreateSchedule(ScheduleCreateDto newSchedule);
    Task<ScheduleGetAllDto>? GetScheduleById(int id);
    Task<List<ScheduleGetAllDto>>? UpdateSchedules(int id, ScheduleUpdateDto updateSchedule);
    Task<List<ScheduleGetAllDto>>? DeleteSchedules(int id);
}