using Microsoft.EntityFrameworkCore;
using QuizAppService.Models.Domain;

namespace QuizAppService.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<SessionUser> SessionUsers { get; set; }
}