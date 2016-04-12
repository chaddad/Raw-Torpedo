using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using RawTorpedo.Models;
using RawTorpedo.Models.Support;

namespace RawTorpedo.Controllers
{
    public class DesignersController : Controller
    {
        private ApplicationDbContext _context;

        public DesignersController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Designers
        public IActionResult Index()
        {
            return View(_context.Designer.ToList());
        }

        // GET: Designers/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Designer designer = _context.Designer.Single(m => m.ID == id);
            if (designer == null)
            {
                return HttpNotFound();
            }

            return View(designer);
        }

        // GET: Designers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Designers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Designer designer)
        {
            if (ModelState.IsValid)
            {
                _context.Designer.Add(designer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(designer);
        }

        // GET: Designers/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Designer designer = _context.Designer.Single(m => m.ID == id);
            if (designer == null)
            {
                return HttpNotFound();
            }
            return View(designer);
        }

        // POST: Designers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Designer designer)
        {
            if (ModelState.IsValid)
            {
                _context.Update(designer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(designer);
        }

        // GET: Designers/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Designer designer = _context.Designer.Single(m => m.ID == id);
            if (designer == null)
            {
                return HttpNotFound();
            }

            return View(designer);
        }

        // POST: Designers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Designer designer = _context.Designer.Single(m => m.ID == id);
            _context.Designer.Remove(designer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
