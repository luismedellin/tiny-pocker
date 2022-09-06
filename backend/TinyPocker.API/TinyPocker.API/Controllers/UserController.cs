using Microsoft.AspNetCore.Mvc;
using TinyPocker.API.Core.DTOs;
using TinyPocker.API.Core.Services;

namespace TinyPocker.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRoomService roomService;

        public UserController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] UserDto userDto)
        {
            await roomService.AddUser(userDto);

            return Ok($"User added to Room #{userDto.RoomId} ");
        }

        [HttpDelete("{roomId}/{userId}")]
        public async Task<IActionResult> DeleteUserHistory(string roomId, string userId)
        {
            await roomService.RemoveUser(roomId, userId);

            return Ok("User removed");
        }
    }
}
