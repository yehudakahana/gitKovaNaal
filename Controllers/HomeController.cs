using gitKovaNaal.DAL;
using gitKovaNaal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace gitKovaNaal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HatIndex()
        {
            return View(Data.Get.Hats);
        }
        public IActionResult CreateHat()
        { 
        return View(new Hat());
        }
        [HttpPost, ValidateAntiForgeryToken]

        public IActionResult CreateHat(Hat NewHat)
        { 
            if (NewHat == null) { return Redirect("Index");}
            var hat = new Hat();
            hat = NewHat;
            Data.Get.Hats.Add(hat);
            Data.Get.SaveChanges();
            
            

        return RedirectToAction("HatIndex");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
