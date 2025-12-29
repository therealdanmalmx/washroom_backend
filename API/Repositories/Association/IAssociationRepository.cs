using Core.Models;

namespace API.Repositories;

public interface IAssociationRepository
{
    List<Association> GetAllAssociations();
}