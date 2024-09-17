using Microsoft.AspNetCore.Mvc;

namespace token_implementation.Controllers;
[Route("api/[controller]")]
public class TokenController : Controller
{
    [HttpGet("")]
    public string Get()
    {
        return "Ok();";
    }
}
