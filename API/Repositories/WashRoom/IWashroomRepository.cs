using Core.Models;

namespace API.Repositories;

public interface IWashroomRepository
{
    Task<List<WashRoom>> GetAllWashrooms();
    Task<List<WashRoom>> CreateWashrooms(WashRoom newWashroom);
    Task<WashRoom>? GetWashroomById(Guid id);
    Task<List<WashRoom>>? UpdateWashroom(Guid id, WashRoom updateWashroom);
    Task<List<WashRoom>>? DeleteWashroom(Guid id);
}