using Microsoft.AspNetCore.Mvc;
using RentaCarKDS.Data;
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
            var carViewModel = new CarViewModel()
            {
                Car = CarRepository.Cars,
                TableCategory = TableCategoryRepository.TableCategories
            };
            return View(carViewModel);
        }

    }
}
