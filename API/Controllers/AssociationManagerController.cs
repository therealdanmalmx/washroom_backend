using API.Services;
using API.Services.AssociationManager;
using Core.DTOs.AssociationManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AssociationManagerController : ControllerBase
    {
       private readonly IAssociationManagerService  _associationManagerService;

       public AssociationManagerController(IAssociationManagerService associationManagerService)
       {
           _associationManagerService = associationManagerService;
       }

       [HttpGet]
        public ActionResult<List<AssociationManagerGetAllDto>> GetAllAssociationManagers()
        {
            return Ok(_associationManagerService.GetAllAssociationManagers());
        }

        [HttpPost]
        public ActionResult<List<AssociationManagerGetAllDto>> CreateAssociationManager(
            AssociationManagerCreateDto newAssociationManager)
        {
            return  Ok(_associationManagerService.CreateAssociationManager(newAssociationManager));
        }

        [HttpGet("{id}")]
        public ActionResult<AssociationManagerGetAllDto> GetAssociationManagerById(int id)
        {
            return Ok(_associationManagerService.GetAssociationManagerById(id));
        }

        [HttpPut("{id}")]
        public ActionResult<List<AssociationManagerGetAllDto>> UpdateAssociationManager(int id,
            AssociationManagerUpdateDto associationManagerUpdateDto)
        {
            return Ok(_associationManagerService.UpdateAssociationManager(id, associationManagerUpdateDto));
        }

        [HttpDelete("{id}")]
        public ActionResult<AssociationManagerGetAllDto> DeleteAssociationManager(int id)
        {
            return Ok(_associationManagerService.DeleteAssociationManager(id));
        }
        
    }
}
