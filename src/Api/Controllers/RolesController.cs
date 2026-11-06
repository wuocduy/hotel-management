using HotelManagement.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Web.Controllers;

public sealed class RolesController(IRoleService roleService) : Controller
{
    public IActionResult Index() => View(roleService.GetAll());
}
