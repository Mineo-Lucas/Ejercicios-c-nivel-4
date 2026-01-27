using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Pokedex_mvc.Controllers
{
    public class ControladorPokemones : Controller
    {
        // GET: ControladorPokemones
        public ActionResult Index()
        {
            return View();
        }

        // GET: ControladorPokemones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ControladorPokemones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ControladorPokemones/Create
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

        // GET: ControladorPokemones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ControladorPokemones/Edit/5
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

        // GET: ControladorPokemones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ControladorPokemones/Delete/5
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
