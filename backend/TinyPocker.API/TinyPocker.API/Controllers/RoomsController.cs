using Microsoft.AspNetCore.Mvc;
using TinyPocker.API.Core.DTOs;
using TinyPocker.API.Core.Services;

namespace TinyPocker.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService roomService;

        public RoomsController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        [HttpGet("{roomId}")]
        public async Task<IActionResult> GetRoom(string roomId)
        {
            var room = await roomService.GetRoom(roomId);
            if(room == null) return NotFound();

            return Ok(new
            {
                room = room,
                Date = DateTime.Now
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] RoomDto roomDto)
        {
            var newRoom = await roomService.CreateRoom(roomDto);

            return Created($"rooms/{newRoom.RoomId}", newRoom);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRoom([FromBody] RoomDto roomDto)
        {
            await roomService.UpdateRoom(roomDto);

            return Ok("Room updated");
        }
    }
}
