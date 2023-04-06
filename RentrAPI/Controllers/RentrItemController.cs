using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentrAPI.Controllers
{
    public class RentrItemController : Controller
    {
        // GET: RentrItemController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RentrItemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RentrItemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RentrItemController/Create
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

        // GET: RentrItemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RentrItemController/Edit/5
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

        // GET: RentrItemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RentrItemController/Delete/5
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
