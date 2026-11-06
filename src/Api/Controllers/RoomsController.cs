using HotelManagement.Application.Services;
using HotelManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Web.Controllers;

public sealed class RoomsController(IRoomService roomService) : Controller
{
    public IActionResult Index(string? keyword, RoomStatus? status)
    {
        ViewBag.Keyword = keyword;
        ViewBag.Status = status;
        return View(roomService.Search(keyword, status));
    }
}
