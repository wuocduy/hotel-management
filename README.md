# HotelManagement

Website quan ly khach san duoc xay dung bang ASP.NET Core MVC. Dashboard dang dung du lieu mau de phuc vu giao dien va se ket noi SQL Server o giai doan sau.

## Cau truc de doc

```text
src/
  HotelManagement.Domain/
    Entities/                    # Room, Employee, Role va quy tac cot loi

  HotelManagement.Application/
    Abstractions/                # Interface repository
    DTOs/                        # Doi tuong truyen du lieu, chia theo Rooms/Employees/Roles
    Services/                    # Xu ly use case Dashboard, Rooms, Employees, Roles
    ViewModels/                  # Model chi phuc vu mot man hinh, vi du Dashboard

  HotelManagement.Infrastructure/
    Persistence/                 # Du lieu mau in-memory; se thay bang EF Core/SQL Server

  HotelManagement.Web/
    Controllers/                 # Dieu huong trang MVC
    Views/
      Auth/                      # Giao dien Dang nhap, Dang ky (chi front-end)
      Dashboard/ Rooms/ ...      # Giao dien tung chuc nang
      Shared/                    # Layout dung chung
    wwwroot/
      css/                       # Style giao dien
      js/                        # JavaScript giao dien
```

## Giao dien dang nhap va dang ky

`/Auth/Login` va `/Auth/Register` la giao dien front-end. Form co validation HTML/JavaScript co ban, khong gui du lieu, khong luu tai khoan va khong co authentication backend.

Khi can lam backend, tao feature `Authentication` trong Application va Infrastructure, sau do ket noi form voi API hoac action MVC.

## Chay du an

```powershell
dotnet restore
dotnet run --project src/HotelManagement.Web
```

Mo trang Dashboard tai dia chi ma terminal hien thi. Form demo nam tai `/Auth/Login` va `/Auth/Register`.
