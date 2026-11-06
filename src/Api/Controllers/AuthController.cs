using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Web.Controllers;

// Front-end navigation only. Authentication logic will be added with the API later.
public sealed class AuthController : Controller
{
    [HttpGet]
    public IActionResult Login() => View();

    [HttpGet]
    public IActionResult Register() => View();
}
