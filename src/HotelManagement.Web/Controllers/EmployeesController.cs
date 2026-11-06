using HotelManagement.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Web.Controllers;

public sealed class EmployeesController(IEmployeeService employeeService) : Controller
{
    public IActionResult Index() => View(employeeService.GetAll());
}
