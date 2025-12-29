using Core.Models;

namespace API.Repositories;

public interface IAssociationRepository
{
    List<Association> GetAllAssociations();
    List<Association> CreateAssociation(Association association);
    Association? GetAssociationById(int id);
    List<Association> UpdateAssociation(int id, Association association);
    List<Association>? DeleteAssociation(int id);
}