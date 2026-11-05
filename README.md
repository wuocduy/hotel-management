# HotelManagement

Starter project ASP.NET Core MVC cho he thong quan ly khach san, duoc tach theo Clean Architecture va dua tren cac man hinh trong wireframe: tong quan, phong, nhan vien va phan quyen.

## Cau truc

```
src/
  HotelManagement.Domain/         # Entity va quy tac cot loi, khong phu thuoc framework
  HotelManagement.Application/    # Use case, DTO/view model va abstraction repository
  HotelManagement.Infrastructure/ # Hien thuc persistence; tam dung in-memory
  HotelManagement.Web/            # ASP.NET MVC: controller, Razor view, CSS layout
tests/
  HotelManagement.Application.Tests/
```

Huong phu thuoc: `Web -> Application <- Infrastructure` va `Application -> Domain`. Domain khong biet UI, EF Core hay SQL Server.

## Chuyen sang SQL Server

1. Them `Microsoft.EntityFrameworkCore.SqlServer` va `Microsoft.EntityFrameworkCore.Tools` vao `HotelManagement.Infrastructure`.
2. Tao `HotelDbContext` trong `Infrastructure/Persistence`, mapping cac entity Domain qua Fluent API.
3. Tao repository EF Core implement `IHotelReadRepository`.
4. Doi dang ky `InMemoryHotelReadRepository` trong `Infrastructure/DependencyInjection.cs` sang EF repository va `AddDbContext` voi connection string tu `Web/appsettings.json`.
5. Tao migration va chay `dotnet ef database update`.

## Chay ung dung

```powershell
dotnet run --project src/HotelManagement.Web
```

Du lieu dang hien thi la du lieu mau, co chu dich nam trong Infrastructure de UI va Application khong bi khoa vao database.
