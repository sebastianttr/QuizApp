using QuizAppService.Data;
using QuizAppService.Models.Domain;
using QuizAppService.Repository.Interface;

namespace QuizAppService.Repository.Implementation;

public class SessionUserRepository : ISessionUserRepository
{
    private readonly ApplicationDbContext _dbContext;
    
    public SessionUserRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<SessionUser> CreateUser(SessionUser sessionUser)
    {
        await _dbContext.SessionUsers.AddAsync(sessionUser);
        await _dbContext.SaveChangesAsync();

        return sessionUser;
    }
}