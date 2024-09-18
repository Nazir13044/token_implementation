using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace token_implementation.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class TokenController : Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World");
    }
}
