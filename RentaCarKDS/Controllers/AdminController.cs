using Microsoft.AspNetCore.Mvc;
using RentaCarKDS.Models;

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
        public IActionResult Addcar(IFormCollection form)
        {
            DatabaseContext db = new DatabaseContext();
            Car car = new Car();
            car.StartDate = form["StartDate"];
            car.FinishDate = form["FinishDate"];
            car.ChassisNo = form["ChassisNo"];
            car.Plate = form["Plate"];
            car.Type = form["Type"];
            //car.DatePrice = form["DatePrice"];
            car.DepartmentCity = form["DepartmentCity"];
            db.Cars.AddRange(car);
            db.SaveChanges();
            return View();
        }
    }
}
