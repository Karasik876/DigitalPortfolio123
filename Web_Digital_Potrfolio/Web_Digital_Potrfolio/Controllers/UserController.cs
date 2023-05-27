using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web_Digital_Potrfolio.Models;
using Web_Digital_Potrfolio.ViewModels;

namespace Web_Digital_Potrfolio.Controllers;

public class UserController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Registration() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Registration(RegistrationViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new User
            {
                Surname = model.Surname,
                Name = model.Name,
                Patronymic = model.Patronymic,
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Index", "Home");
            }
            else
                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
        }

        return View(model);
    }
}