using System.ComponentModel.DataAnnotations;

namespace Web_Digital_Potrfolio.Models;

public class Portfolio
{
   public long Id { get; set; }
   
   [Required]
   [StringLength(125)]
   public string? Title { get; set; }
   
   public string? Text { get; set; }
   
   [Required]
   public string? UrlGitHub { get; set; }
   
   [Required]
   public int UserId { get; set; }
   
   
   public virtual User User { get; set; }
}