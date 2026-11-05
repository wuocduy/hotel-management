using HotelManagement.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Web.Controllers;

 [Authorize]
public sealed class RolesController(IRoleService roleService) : Controller
{
    public IActionResult Index() => View(roleService.GetAll());
}
