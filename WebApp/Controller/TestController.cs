using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controller;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Test()
    {
        return Ok("OkiDoki");
    }
}