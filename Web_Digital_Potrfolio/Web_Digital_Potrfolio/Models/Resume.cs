using System.ComponentModel.DataAnnotations;

namespace Web_Digital_Potrfolio.Models;

public class Resume
{
    [Key]
    public long Id { get; set; }
    
    public string? Surname { get; set; }
    
    public string? Name { get; set; }
    
    public string? Patronymic { get; set; }
    
    [EmailAddress]
    public string? Email { get; set; }
    
    [Phone]
    public string? PhoneNumber { get; set; }
    
    public string? VkLink { get; set; }
    
    public string? TelegramLink { get; set; }
    
    public long UserId { get; set; }
    
    [Required]
    public string? Address { get; set; }
    
    [Required]
    public int GenderId { get; set; }
    
    [Required]
    public int FamilyStatusId { get; set; }

    [Required]
    public string? About { get; set; }
    
    
    public virtual User User { get; set; }
    public virtual Gender Gender { get; set; }
    public virtual FamilyStatus FamilyStatus { get; set; }
}