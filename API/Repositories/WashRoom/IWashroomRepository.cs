using Core.Models;

namespace API.Repositories;

public interface IWashroomRepository
{
    List<WashRoom> GetAllWashrooms();
    List<WashRoom> CrateWashrooms(WashRoom newWashroom);
    WashRoom? GetWashroomById(int id);
    List<WashRoom>? UpdateWashroom(int id, WashRoom updateWashroom);
    List<WashRoom>? DeleteWashroom(int id);
}