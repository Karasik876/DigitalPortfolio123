using System.ComponentModel.DataAnnotations;

namespace Web_Digital_Potrfolio.ViewModels;

public class LoginViewModel
{
    [Required(ErrorMessage = "Данное поле не заполнено")]
    [Display(Name = "Имя пользователя")]
    public string? UserName { get; set; }
    
    [Required(ErrorMessage = "Данное поле не заполнено")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
    
    [Display(Name = "Запомнить меня")]
    public bool RememberMe { get; set; }
    
    public string? ReturnUrl { get; set; }
}