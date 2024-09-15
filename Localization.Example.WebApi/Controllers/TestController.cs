using LocalizationLibrary;
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
            message = _localizer[LocalizationKeys.Common.NotFoundEntity];
        }
        
        return Ok(new { message });
    }
    
    [HttpGet("dynamic/{name}")]
    public IActionResult GetDynamic(string name)
    {
        if (name.Length > 5)
        {
            return Ok(_localizer[LocalizationKeys.GreetingMessage].Value);
        }
        
        return BadRequest(_localizer[LocalizationKeys.DynamicMessage, "Name", 5].Value);
    }
}