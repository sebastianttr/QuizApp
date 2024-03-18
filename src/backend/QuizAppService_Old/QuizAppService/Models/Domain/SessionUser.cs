namespace QuizAppService.Models.Domain;

public class SessionUser
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public DateTime Joined { get; set; }
}