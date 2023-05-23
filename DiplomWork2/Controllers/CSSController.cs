using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiplomWork2.Controllers
{
    public class CSSController : Controller
    {
        // GET: CSSController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CSSController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CSSController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CSSController/Create
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

        // GET: CSSController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CSSController/Edit/5
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

        // GET: CSSController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CSSController/Delete/5
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
