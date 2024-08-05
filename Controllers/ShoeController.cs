using gitKovaNaal.DAL;
using gitKovaNaal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace gitKovaNaal.Controllers
{
    public class ShoeController : Controller
    {
        // GET: ShoeController
       

        //הצגת הנעליים
        public IActionResult ShoeIndex()
        {
            return View(Data.Get.Shoes);
        }
        //יצירת נעל
        public IActionResult CreateShoe()
        {
            return View(new Shoe());
        }


        [HttpPost, ValidateAntiForgeryToken]

        //אישור יצירת נעל
        public IActionResult CreateShoe(Shoe NewShoe)
        {
            if (NewShoe == null) { return Redirect("Index"); }
           
            Data.Get.Shoes.Add(NewShoe);
            Data.Get.SaveChanges();

            return RedirectToAction("ShoeIndex");
        }





















        // GET: ShoeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShoeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShoeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShoeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
