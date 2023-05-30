using System.ComponentModel.DataAnnotations;

namespace Web_Digital_Potrfolio.Models;

public class Gender
{
    public int Id { get; set; }
    
    [Required]
    public string? Title { get; set; }


    public virtual List<Resume> Resumes { get; set; } = new List<Resume>();
    public virtual List<User> Users { get; set; } = new List<User>();
}