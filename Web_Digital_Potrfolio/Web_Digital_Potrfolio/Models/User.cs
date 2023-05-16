using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Web_Digital_Potrfolio.Models;

public class User : IdentityUser
{
    [Required]
    public string? Surname { get; set; }
    
    [Required]
    public string? Name { get; set; }
    
    [Required]
    public string? Patronymic { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime DateBirth { get; set; }
}