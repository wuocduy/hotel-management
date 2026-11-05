using HotelManagement.Application.Services;
using HotelManagement.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Web.Controllers;

 [Authorize]
public sealed class RoomsController(IRoomService roomService) : Controller
{
    public IActionResult Index(string? keyword, RoomStatus? status)
    {
        ViewBag.Keyword = keyword;
        ViewBag.Status = status;
        return View(roomService.Search(keyword, status));
    }
}
