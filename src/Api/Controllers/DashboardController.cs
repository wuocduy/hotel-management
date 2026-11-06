using HotelManagement.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Web.Controllers;

public sealed class DashboardController(IDashboardService dashboardService) : Controller
{
    public IActionResult Index() => View(dashboardService.GetOverview());
}
