using Core.Models;

namespace API.Repositories;

public interface IWashroomRepository
{
    Task<List<WashRoom>> GetAllWashrooms();
    Task<List<WashRoom>> CreateWashrooms(WashRoom newWashroom);
    Task<WashRoom>? GetWashroomById(int id);
    Task<List<WashRoom>>? UpdateWashroom(int id, WashRoom updateWashroom);
    Task<List<WashRoom>>? DeleteWashroom(int id);
}