using API.Services.WashRoom;
using Core.DTOs.WashRoom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class WashroomController : ControllerBase
    {
        
        private readonly IWashroomService _washroomService;

        public WashroomController(IWashroomService washroomService)
        {
            _washroomService = washroomService;
        }


        [HttpGet]
        public ActionResult<List<WashRoomGetAllDto>> GetAllWashrooms()
        {
            return Ok(_washroomService.GetAllWashRooms());
        }

        [HttpPost]
        public ActionResult<List<WashRoomGetAllDto>> CreateWashRoom(WashRoomCreateDto newWashroom)
        {
            return Ok(_washroomService.CreateWashRoom(newWashroom));
        }

        [HttpGet("{id}")]
        public ActionResult<WashRoomGetAllDto> GetWashRoomById(int id)
        {
            var singleWashroom = _washroomService.GetWashRoomById(id);
            if (singleWashroom == null)
            {
                return NotFound();
            }
            return Ok(singleWashroom);
        }

        [HttpPut("{id}")]
        public ActionResult<List<WashRoomGetAllDto>> UpdateWashRoom(int id, WashRoomUpdateDto updateWashroom)
        {
            var washroomToUpdate = _washroomService.UpdateWashRoom(id, updateWashroom);
            if (washroomToUpdate == null)
            {
                return NotFound();
            }
            return Ok(washroomToUpdate);
        }

        [HttpDelete("{id}")]
        public ActionResult<List<WashRoomGetAllDto>>? DeleteWashRoom(int id)
        {
            var washroomToDelete = _washroomService.DeleteWashRoom(id);
            if (washroomToDelete == null)
            {
                return NotFound();
            }
            return Ok(washroomToDelete);
        }
    }
}
