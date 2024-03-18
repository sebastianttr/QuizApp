using Microsoft.AspNetCore.Mvc;
using QuizAppService.Models.Domain;
using QuizAppService.Models.DTO;
using QuizAppService.Repository.Interface;

namespace QuizAppService.Controllers;

[ApiController]
[Route("/api/sessionuser")]
public class SessionUserController(ILogger<SessionUserController> logger, ISessionUserRepository sessionUserRepository) : Controller
{
    [HttpGet]
    public IActionResult GetSessionUsers()
    {
        return Ok();
    }
    
    [HttpGet("{id:Guid}")]
    public IActionResult GetSessionUser([FromRoute] Guid id)
    {
        return Ok();
    }
    
    
    [HttpPost]
    public async Task<IActionResult> CreateSessionUser(SessionUserDto sessionUserDto)
    {
        var sessionUser = new SessionUser
        {
            Username = sessionUserDto.Username,
        };

        await sessionUserRepository.CreateUser(sessionUser);

        var response = new SessionUserDto
        {
            Id = sessionUser.Id,
            Username = sessionUser.Username,
            Joined = sessionUser.Joined
        };
        
        return Ok(response);
    }
}