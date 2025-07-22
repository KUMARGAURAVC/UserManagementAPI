using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;
using UserManagementAPI.Services;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        // GET: api/users
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var users = await _userService.GetAllUsersAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

        // POST: api/users
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            await _userService.AddUserAsync(user);
            return CreatedAtAction(nameof(GetAllUsers), new { id = user.Id }, user);
        }
    }
}