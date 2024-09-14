using LocalizationLibrary.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Localization.Example.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly IStringLocalizer<SharedResource> _localizer;

    public TestController(IStringLocalizer<SharedResource> localizer)
    {
        _localizer = localizer;
    }
    
    [HttpGet("greeting/{value}")]
    public IActionResult GetGreeting(int value)
    {
        string message = "";
        
        if (value > 0)
        {
            message = _localizer["GreetingMessage"];
        }
        else
        {
            message = _localizer["ErrorMessage"];
        }
        
        return Ok(new { message });
    }
}