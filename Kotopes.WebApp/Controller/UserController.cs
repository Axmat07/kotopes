using Kotopes.Application;
using Kotopes.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controller;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> AddUser(User user, CancellationToken token)
    {
        var result = await _userService.AddUser(user, token);
        
        if (result == null)
        {
            return BadRequest();
        }
        
        return Ok(result);
    }
}