using Microsoft.AspNetCore.Mvc;
using RentaCarKDS.Models;

namespace RentaCarKDS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            var car = new List<Car>
            {
                new Car {Id = 105846, StartDate= "31.12.2023", FinishDate = "02.01.2023", Price = 1100, ChassisNo = "26AXFA5WAEVN", Type = "Economic", Plate = "38 LI 010" }, //Price toplam fiyattır.
                new Car {Id = 109963, StartDate= "01.11.2023", FinishDate = "12.11.2023", Price = 8731, ChassisNo = "611AZGB916IB", Type = "Standard", Plate = "34 HIZ 034" }, //Price toplam fiyattır.
                new Car {Id = 109961, StartDate= "01.12.2023", FinishDate = "04.12.2023", Price = 9116, ChassisNo = "912PRSH044BS", Type = "Premium", Plate = "48 MSK 001" }, //Price toplam fiyattır.
                new Car {Id = 100398, StartDate= "03.04.2023", FinishDate = "04.05.2023", Price = 3849, ChassisNo = "ASD44DSC8AQB", Type = "Standard", Plate = "54 AS 661" }, //Price toplam fiyattır.
                new Car {Id = 101248, StartDate= "14.10.2023", FinishDate = "25.10.2023", Price = 2328, ChassisNo = "CSDZ61ERG8QX", Type = "Standard", Plate = "36 NG 179" }, //Price toplam fiyattır.
                new Car {Id = 105791, StartDate= "17.12.2023", FinishDate = "30.12.2023", Price = 1010, ChassisNo = "XV5QWD7VDS85", Type = "Standard", Plate = "29 KF 394" }, //Price toplam fiyattır.
                new Car {Id = 100395, StartDate= "03.01.2023", FinishDate = "20.01.2023", Price = 5501, ChassisNo = "AVA89QWFDF6Z", Type = "Standard", Plate = "47 BO 318" }, //Price toplam fiyattır.
                new Car {Id = 100393, StartDate= "04.10.2023", FinishDate = "19.10.2023", Price = 3861, ChassisNo = "JUI9L5SDF14A", Type = "Economic", Plate = "14 PL 916" }, //Price toplam fiyattır.
                new Car {Id = 100392, StartDate= "09.12.2023", FinishDate = "04.12.2023", Price = 9841, ChassisNo = "SVA49AS419AC", Type = "Premium", Plate = "48 EST 013" }, //Price toplam fiyattır.
                new Car {Id = 100391, StartDate= "20.09.2023", FinishDate = "24.09.2023", Price = 1995, ChassisNo = "AV6B86TFOILK", Type = "Economic", Plate = "06 AA 001" }, //Price toplam fiyattır.
                new Car {Id = 100361, StartDate= "22.09.2023", FinishDate = "29.09.2023", Price = 5415, ChassisNo = "UK6HUL29ASCV", Type = "Economic", Plate = "48 AA 001" } //Price toplam fiyattır.
            };

            var categories = new List<TableCategory>
            {
                new TableCategory {Name = "Id", Description = "empty"},
                new TableCategory {Name = "StartDate", Description = "empty"},
                new TableCategory {Name = "FinishDate", Description = "empty"},
                new TableCategory {Name = "ChassisNo", Description = "empty"},
                new TableCategory {Name = "Plate", Description = "empty"},
                new TableCategory {Name = "Type", Description = "empty"},
                new TableCategory {Name = "Price", Description = "empty"},
            };
            var carViewModel = new CarViewModel()
            {
                Car = car,
                TableCategory = categories
            };
            return View(carViewModel);
        }
    }
}
