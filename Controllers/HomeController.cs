using Microsoft.AspNetCore.Mvc;
using WebApplicationApp.Models;

namespace WebApplicationApp.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            Home home1= new Home();
            home1.Regno = 217789999;
            home1.Name = "waka";
            return View(home1);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Home home)
        {
            if (ModelState.IsValid)
            {
                return Content("Success!!");
            }
            else
            {
                return View(home);
            }
        }
    }
}