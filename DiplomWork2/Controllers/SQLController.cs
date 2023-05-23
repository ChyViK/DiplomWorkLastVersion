using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiplomWork2.Controllers
{
    public class SQLController : Controller
    {
        // GET: SQLController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SQLController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SQLController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SQLController/Create
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

        // GET: SQLController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SQLController/Edit/5
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

        // GET: SQLController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SQLController/Delete/5
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
