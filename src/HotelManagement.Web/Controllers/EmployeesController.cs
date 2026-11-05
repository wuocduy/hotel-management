using HotelManagement.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Web.Controllers;

 [Authorize]
public sealed class EmployeesController(IEmployeeService employeeService) : Controller
{
    public IActionResult Index() => View(employeeService.GetAll());
}
