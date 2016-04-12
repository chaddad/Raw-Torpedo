using System.Linq;
using Microsoft.AspNet.Mvc;
using RawTorpedo.Models;

namespace RawTorpedo.Controllers
{
    public class CollectionsController : Controller
    {
        private ApplicationDbContext _context;

        public CollectionsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Collections
        public IActionResult Index()
        {
            return View(_context.Collection.ToList());
        }

        // GET: Collections/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Collection collection = _context.Collection.Single(m => m.ID == id);
            if (collection == null)
            {
                return HttpNotFound();
            }

            return View(collection);
        }

        // GET: Collections/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Collections/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Collection collection)
        {
            if (ModelState.IsValid)
            {
                _context.Collection.Add(collection);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(collection);
        }

        // GET: Collections/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Collection collection = _context.Collection.Single(m => m.ID == id);
            if (collection == null)
            {
                return HttpNotFound();
            }
            return View(collection);
        }

        // POST: Collections/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Collection collection)
        {
            if (ModelState.IsValid)
            {
                _context.Update(collection);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(collection);
        }

        // GET: Collections/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Collection collection = _context.Collection.Single(m => m.ID == id);
            if (collection == null)
            {
                return HttpNotFound();
            }

            return View(collection);
        }

        // POST: Collections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Collection collection = _context.Collection.Single(m => m.ID == id);
            _context.Collection.Remove(collection);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
