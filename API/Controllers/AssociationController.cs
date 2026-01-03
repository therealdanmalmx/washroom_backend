using API.Services.Association;
using Core.DTOs.Association;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AssociationController : ControllerBase
    {
        private readonly IAssociationService _associationService;

        public AssociationController(IAssociationService associationService)
        {
            _associationService = associationService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AssociationGetAllDto>>> GetAllAssociations()
        {
            return Ok(await _associationService.GetAllAssociations());
        }

        [HttpPost]
        public async Task<ActionResult<List<AssociationCreateDto>>> CreateAssociation(AssociationCreateDto newAssociation)
        {
            return Ok(await _associationService.CreateAssociation(newAssociation));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AssociationGetAllDto>> GetAssociationById(int id)
        {
            return Ok(await _associationService.GetAssociationById(id));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AssociationGetAllDto>> UpdateAssociation(int id, AssociationUpdateDto associationUpdateDto)
        {
            return Ok(await _associationService.UpdateAssociation(id, associationUpdateDto));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<AssociationGetAllDto>>> DeleteAssociation(int id)
        {
            return Ok(await _associationService.DeleteAssociation(id));
        }
    }
}
