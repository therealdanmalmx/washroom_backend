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
        public async Task<ActionResult<List<WashRoomGetAllDto>>> GetAllWashrooms()
        {
            return Ok(await _washroomService.GetAllWashRooms());
        }

        [HttpPost]
        public async Task<ActionResult<List<WashRoomGetAllDto>>> CreateWashRoom(WashRoomCreateDto newWashroom)
        {
            return Ok(await _washroomService.CreateWashRoom(newWashroom));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WashRoomGetAllDto>> GetWashRoomById(int id)
        {
            var singleWashroom = await _washroomService.GetWashRoomById(id);
            if (singleWashroom == null)
            {
                return NotFound();
            }
            return Ok(singleWashroom);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<WashRoomGetAllDto>>> UpdateWashRoom(int id, WashRoomUpdateDto updateWashroom)
        {
            var washroomToUpdate = await _washroomService.UpdateWashRoom(id, updateWashroom);
            if (washroomToUpdate == null)
            {
                return NotFound();
            }
            return Ok(washroomToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<WashRoomGetAllDto>>>? DeleteWashRoom(int id)
        {
            var washroomToDelete = await _washroomService.DeleteWashRoom(id);
            if (washroomToDelete == null)
            {
                return NotFound();
            }
            return Ok(washroomToDelete);
        }
    }
}
