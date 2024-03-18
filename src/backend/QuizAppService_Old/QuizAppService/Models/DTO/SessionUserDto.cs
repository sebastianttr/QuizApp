using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAppService.Models.DTO;

[Table("SessionUser")]
public class SessionUserDto
{
    public Guid Id { get; set; }

    [Required]
    public string Username { get; set; }
    
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime Joined { get; set; }
}