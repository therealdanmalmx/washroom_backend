using Core.DTOs.Schedule;

namespace API.Services.Schedule;

public interface IScheduleService
{
    List<ScheduleGetAllDto> GetAllSchedules();
    List<ScheduleGetAllDto> CreateSchedule(ScheduleCreateDto newSchedule);
    ScheduleGetAllDto? GetScheduleById(int id);
    List<ScheduleGetAllDto>? UpdateSchedules(int id, ScheduleUpdateDto updateSchedule);
    List<ScheduleGetAllDto>? DeleteSchedules(int id);
}