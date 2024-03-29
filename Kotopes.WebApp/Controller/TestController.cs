﻿using Kotopes.Application;
using Kotopes.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controller;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly IUserService _userService;

    public TestController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    [Route("[action]")]
    public IActionResult Test()
    {
        return Ok("OkiDoki");
    }
    
    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> AddTestUser(CancellationToken token)
    {
        var user = new User
        {
            Email = "test@test.com",
            FirstName = "TestFirstName",
            LastName = "TestLastName",
            TelegramId = "TestTelegramID"
        };
        var id = await _userService.AddUser(user, token);
        
        if (id != null)
        {
            await _userService.DeleteUser(id.Value, token);
        }

        return Ok(id);
    }
}