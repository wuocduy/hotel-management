using HotelManagement.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Web.Controllers;

 [Authorize]
public sealed class DashboardController(IDashboardService dashboardService) : Controller
{
    public IActionResult Index() => View(dashboardService.GetOverview());
}
