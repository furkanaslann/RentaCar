using Microsoft.AspNetCore.Mvc;
using RentaCarKDS.Models;
using System.Collections.Generic;

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
                new Car {Id = 105846, StartDate= "31.12.2023", FinishDate = "02.01.2023", DatePrice = 350, ChassisNo = "26AXFA5WAEVN", Type = "Economic", Plate = "38 LI 010", DepartmentCity="Kayseri" }, // Ekonomik parametre:0-499
                new Car {Id = 109963, StartDate= "01.11.2023", FinishDate = "12.11.2023", DatePrice = 559, ChassisNo = "611AZGB916IB", Type = "Standard", Plate = "34 HIZ 034", DepartmentCity="Muğla"}, // Standart parametre:500-999
                new Car {Id = 109961, StartDate= "01.12.2023", FinishDate = "04.12.2023", DatePrice = 1248, ChassisNo = "912PRSH044BS", Type = "Premium", Plate = "48 MSK 001", DepartmentCity="İstanbul"}, // Premium parametre:1000-...
                new Car {Id = 100398, StartDate= "03.04.2023", FinishDate = "04.05.2023", DatePrice = 540, ChassisNo = "ASD44DSC8AQB", Type = "Standard", Plate = "54 AS 661", DepartmentCity="Konya"},  
                new Car {Id = 101248, StartDate= "14.10.2023", FinishDate = "25.10.2023", DatePrice = 661, ChassisNo = "CSDZ61ERG8QX", Type = "Standard", Plate = "36 NG 179", DepartmentCity="Sivas"}, 
                new Car {Id = 105791, StartDate= "17.12.2023", FinishDate = "30.12.2023", DatePrice = 680, ChassisNo = "XV5QWD7VDS85", Type = "Standard", Plate = "29 KF 394", DepartmentCity="İzmir"}, 
                new Car {Id = 100395, StartDate= "03.01.2023", FinishDate = "20.01.2023", DatePrice = 505, ChassisNo = "AVA89QWFDF6Z", Type = "Standard", Plate = "47 BO 318", DepartmentCity="İstanbul"}, 
                new Car {Id = 100393, StartDate= "04.10.2023", FinishDate = "19.10.2023", DatePrice = 415, ChassisNo = "JUI9L5SDF14A", Type = "Economic", Plate = "14 PL 916", DepartmentCity="Adana"}, 
                new Car {Id = 100392, StartDate= "09.12.2023", FinishDate = "04.12.2023", DatePrice = 9841, ChassisNo = "SVA49AS419AC", Type = "Premium", Plate = "48 EST 013", DepartmentCity="Edirne"}, 
                new Car {Id = 100391, StartDate= "20.09.2023", FinishDate = "24.09.2023", DatePrice = 1995, ChassisNo = "AV6B86TFOILK", Type = "Economic", Plate = "06 AA 001", DepartmentCity="Balıkesir"}, 
                new Car {Id = 100361, StartDate= "22.09.2023", FinishDate = "29.09.2023", DatePrice = 5415, ChassisNo = "UK6HUL29ASCV", Type = "Economic", Plate = "48 AA 001", DepartmentCity="Çanakkale"} 
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
                new TableCategory {Name = "City", Description = "empty"},
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
