using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiplomWork2.Controllers
{
    public class PYTHONController : Controller
    {
        // GET: PYTHONController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PYTHONController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PYTHONController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PYTHONController/Create
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

        // GET: PYTHONController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PYTHONController/Edit/5
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

        // GET: PYTHONController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PYTHONController/Delete/5
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
