using System.Linq;
using Microsoft.AspNet.Mvc;
using RawTorpedo.Models;
using RawTorpedo.Models.Support;

namespace RawTorpedo.Controllers
{
    public class PublishersController : Controller
    {
        private ApplicationDbContext _context;

        public PublishersController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Publishers
        public IActionResult Index()
        {
            return View(_context.Publisher.ToList());
        }

        // GET: Publishers/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Publisher publisher = _context.Publisher.Single(m => m.ID == id);
            if (publisher == null)
            {
                return HttpNotFound();
            }

            return View(publisher);
        }

        // GET: Publishers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Publishers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                _context.Publisher.Add(publisher);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publisher);
        }

        // GET: Publishers/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Publisher publisher = _context.Publisher.Single(m => m.ID == id);
            if (publisher == null)
            {
                return HttpNotFound();
            }
            return View(publisher);
        }

        // POST: Publishers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Publisher publisher)
        {
            if (ModelState.IsValid)
            {
                _context.Update(publisher);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publisher);
        }

        // GET: Publishers/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Publisher publisher = _context.Publisher.Single(m => m.ID == id);
            if (publisher == null)
            {
                return HttpNotFound();
            }

            return View(publisher);
        }

        // POST: Publishers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Publisher publisher = _context.Publisher.Single(m => m.ID == id);
            _context.Publisher.Remove(publisher);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
