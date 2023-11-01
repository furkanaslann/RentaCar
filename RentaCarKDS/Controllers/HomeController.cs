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
                new Car {Id = 105846, StartDate= "31.12.2023", FinishDate = "02.01.2023", Price = 1100, ChassisNo = "26AXFA5WAEVN", Type = "Economic", Plate = "38 LI 010" },
                new Car {Id = 109963, StartDate= "01.11.2023", FinishDate = "12.11.2023", Price = 8731, ChassisNo = "611AZGB916IB", Type = "Standard", Plate = "34 HIZ 034" },
                new Car {Id = 109963, StartDate= "03.12.2023", FinishDate = "04.12.2023", Price = 758, ChassisNo = "912PRSH044BS", Type = "Premium", Plate = "34 TRB 911" }
            };

            var category = new List<Category>
            {
                new Category {Name = "Id", Description = "empty"},
                new Category {Name = "StartDate", Description = "empty"},
                new Category {Name = "FinishDate", Description = "empty"},
                new Category {Name = "ChassisNo", Description = "empty"},
                new Category {Name = "Plate", Description = "empty"},
                new Category {Name = "Type", Description = "empty"},
                new Category {Name = "Price", Description = "empty"},
            };
            var carViewModel = new CarViewModel()
            {
                Car = car,
                Category = category
            };
            return View(carViewModel);
        }
    }
}
