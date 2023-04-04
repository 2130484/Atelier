using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vetements.Controllers
{
    public class MVCVetement : Controller
    {
        // GET: MVCVetement
        public ActionResult Index()
        {
            return View();
        }

        // GET: MVCVetement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MVCVetement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MVCVetement/Create
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

        // GET: MVCVetement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MVCVetement/Edit/5
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

        // GET: MVCVetement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MVCVetement/Delete/5
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
