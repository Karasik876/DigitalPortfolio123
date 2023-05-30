using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Web_Digital_Potrfolio.Models;

public class User : IdentityUser<long>
{
    [Required]
    public string? Surname { get; set; }
    
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public string? Patronymic { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime DateBirth { get; set; }
    
    public int GenderId { get; set; }
    
    public int FamilyStatusId { get; set; }
    
    public string? VkLink { get; set; }
    
    public string? TelegramLink { get; set; }


    public virtual Gender Gender { get; set; }
    public virtual FamilyStatus FamilyStatus { get; set; }

    public virtual List<Resume> Resumes { get; set; } = new List<Resume>();
    public virtual List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
}