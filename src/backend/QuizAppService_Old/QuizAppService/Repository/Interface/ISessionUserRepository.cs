using QuizAppService.Models.Domain;

namespace QuizAppService.Repository.Interface;

public interface ISessionUserRepository
{
    public Task<SessionUser> CreateUser(SessionUser sessionUser);
}