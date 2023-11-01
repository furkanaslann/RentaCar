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
    }
}
