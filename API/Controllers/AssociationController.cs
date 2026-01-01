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
        public ActionResult<List<AssociationGetAllDto>> GetAllAssociations()
        {
            return Ok(_associationService.GetAllAssociations());
        }

        [HttpPost]
        public ActionResult<List<AssociationCreateDto>> CreateAssociation(AssociationCreateDto newAssociation)
        {
            return Ok(_associationService.CreateAssociation(newAssociation));
        }

        [HttpGet("{id}")]
        public ActionResult<AssociationGetAllDto> GetAssociationById(int id)
        {
            return Ok(_associationService.GetAssociationById(id));
        }

        [HttpPut("{id}")]
        public ActionResult<AssociationGetAllDto> UpdateAssociation(int id, AssociationUpdateDto associationUpdateDto)
        {
            return Ok(_associationService.UpdateAssociation(id, associationUpdateDto));
        }

        [HttpDelete("{id}")]
        public ActionResult<List<AssociationGetAllDto>> DeleteAssociation(int id)
        {
            return Ok(_associationService.DeleteAssociation(id));
        }
    }
}
