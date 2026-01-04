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
        public async Task<ActionResult<List<AssociationManagerGetAllDto>>> GetAllAssociationManagers()
        {
            return Ok(await _associationManagerService.GetAllAssociationManagers());
        }

        [HttpPost]
        public async Task<ActionResult<List<AssociationManagerGetAllDto>>> CreateAssociationManager(
            AssociationManagerCreateDto newAssociationManager)
        {
            return  Ok(await _associationManagerService.CreateAssociationManager(newAssociationManager));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AssociationManagerGetAllDto>> GetAssociationManagerById(int id)
        {
            return Ok(await _associationManagerService.GetAssociationManagerById(id));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<AssociationManagerGetAllDto>>> UpdateAssociationManager(int id,
            AssociationManagerUpdateDto associationManagerUpdateDto)
        {
            return Ok(await _associationManagerService.UpdateAssociationManager(id, associationManagerUpdateDto));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AssociationManagerGetAllDto>> DeleteAssociationManager(int id)
        {
            return Ok(await _associationManagerService.DeleteAssociationManager(id));
        }
        
    }
}
