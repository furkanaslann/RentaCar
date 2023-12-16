using Microsoft.AspNetCore.Mvc;
using RentaCarKDS.Models;
using System.Drawing.Imaging;

namespace RentaCarKDS.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Addcar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addcar(Car car)
        {
            Console.WriteLine(car.StartDate);
            Console.WriteLine(car.FinishDate);
            Console.WriteLine(car.ChassisNo);
            Console.WriteLine(car.Plate);
            Console.WriteLine(car.Type);
            Console.WriteLine(car.DatePrice);
            Console.WriteLine(car.DepartmentCity);
            return View();
        }
        public IActionResult Detailscar(Car car) 
        {
            return View(car);
        }
    }
}
