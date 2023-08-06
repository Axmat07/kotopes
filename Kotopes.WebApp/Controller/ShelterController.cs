using Kotopes.Application;
using Kotopes.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controller;

[ApiController]
[Route("[controller]")]
public class ShelterController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IShelterService _shelterService;

    public ShelterController(IUserService userService, IShelterService shelterService)
    {
        _userService = userService;
        _shelterService = shelterService;
    }

    [HttpGet]
    [Route("[action]")]
    public async Task<IActionResult> AddShelter(Shelter shelter, CancellationToken token)
    {
        var result = await _shelterService.AddShelter(shelter, token);
        if (result == null)
        {
            return BadRequest();
        }
        return Ok(result);
    }
}