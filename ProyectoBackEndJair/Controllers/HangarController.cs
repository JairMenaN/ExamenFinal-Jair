using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoBackEndJair.Controllers
{
    public class HangarController : Controller
    {
        // GET: HangarController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HangarController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HangarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HangarController/Create
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

        // GET: HangarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HangarController/Edit/5
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

        // GET: HangarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HangarController/Delete/5
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
