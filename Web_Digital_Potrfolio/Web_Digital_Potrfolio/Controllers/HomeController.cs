using Microsoft.AspNetCore.Mvc;

namespace Web_Digital_Potrfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}