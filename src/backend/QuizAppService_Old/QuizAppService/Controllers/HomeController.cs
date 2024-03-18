using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace QuizAppService.Controllers;

[ApiController]
[Route("")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {  
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetHelloWorld()
    {  
        return Ok("Hello World, now with hot reload...dwadaw");
    }
    
}