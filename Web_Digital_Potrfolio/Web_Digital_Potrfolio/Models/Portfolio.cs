using System.ComponentModel.DataAnnotations;

namespace Web_Digital_Potrfolio.Models;

public class Portfolio
{
   public int Id { get; set; }
   
   [Required]
   [StringLength(125)]
   public string? Title { get; set; }
   
   public string? Text { get; set; }
   
   [Required]
   public string? UrlGitHub { get; set; }
}