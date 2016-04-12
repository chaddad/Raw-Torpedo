using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using RawTorpedo.Models;
using RawTorpedo.Models.Support;

namespace RawTorpedo.Controllers
{
    public class ThemesController : Controller
    {
        private ApplicationDbContext _context;

        public ThemesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Themes
        public IActionResult Index()
        {
            return View(_context.Theme.ToList());
        }

        // GET: Themes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Theme theme = _context.Theme.Single(m => m.ID == id);
            if (theme == null)
            {
                return HttpNotFound();
            }

            return View(theme);
        }

        // GET: Themes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Themes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Theme theme)
        {
            if (ModelState.IsValid)
            {
                _context.Theme.Add(theme);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(theme);
        }

        // GET: Themes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Theme theme = _context.Theme.Single(m => m.ID == id);
            if (theme == null)
            {
                return HttpNotFound();
            }
            return View(theme);
        }

        // POST: Themes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Theme theme)
        {
            if (ModelState.IsValid)
            {
                _context.Update(theme);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(theme);
        }

        // GET: Themes/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Theme theme = _context.Theme.Single(m => m.ID == id);
            if (theme == null)
            {
                return HttpNotFound();
            }

            return View(theme);
        }

        // POST: Themes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Theme theme = _context.Theme.Single(m => m.ID == id);
            _context.Theme.Remove(theme);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
