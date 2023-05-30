using System.ComponentModel.DataAnnotations;

namespace Web_Digital_Potrfolio.ViewModels;

public class RegistrationViewModel
{
    [Required(ErrorMessage = "Данное поле не заполнено")]
    [Display(Name = "Фамилия")]
    public string? Surname { get; set; }
    
    [Required(ErrorMessage = "Данное поле не заполнено")]
    [Display(Name = "Имя")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Данное поле не заполнено")]
    [Display(Name = "Отчество")]
    public string? Patronymic { get; set; }
    
    [Required(ErrorMessage = "Данное поле не заполнено")]
    [Display(Name = "Имя пользователя")]
    public string? UserName { get; set; }
    
    [Required(ErrorMessage = "Данное поле не заполнено")]
    [EmailAddress(ErrorMessage = "Не является Email")]
    [Display(Name = "Email")]
    public string? Email { get; set; }
    
    [Required(ErrorMessage = "Данное поле не заполнено")]
    [MinLength(6, ErrorMessage = "Слишком короткий пароль")]
    [Display(Name = "Пароль", Description = "Пароль не должен содержать не более 6 символов")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
   
    [Required(ErrorMessage = "Данное поле не заполнено")]
    [Compare("Password", ErrorMessage = "Пароли не свопадают")]
    [Display(Name = "Подтвердите пароль")]
    [DataType(DataType.Password)]
    public string? PasswordConfirm { get; set; }
}