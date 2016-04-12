using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using RawTorpedo.Models;
using RawTorpedo.Models.Support;

namespace RawTorpedo.Controllers
{
    public class MechanicsController : Controller
    {
        private ApplicationDbContext _context;

        public MechanicsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Mechanics
        public IActionResult Index()
        {
            return View(_context.Mechanic.ToList());
        }

        // GET: Mechanics/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Mechanic mechanic = _context.Mechanic.Single(m => m.ID == id);
            if (mechanic == null)
            {
                return HttpNotFound();
            }

            return View(mechanic);
        }

        // GET: Mechanics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mechanics/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Mechanic mechanic)
        {
            if (ModelState.IsValid)
            {
                _context.Mechanic.Add(mechanic);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mechanic);
        }

        // GET: Mechanics/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Mechanic mechanic = _context.Mechanic.Single(m => m.ID == id);
            if (mechanic == null)
            {
                return HttpNotFound();
            }
            return View(mechanic);
        }

        // POST: Mechanics/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Mechanic mechanic)
        {
            if (ModelState.IsValid)
            {
                _context.Update(mechanic);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mechanic);
        }

        // GET: Mechanics/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Mechanic mechanic = _context.Mechanic.Single(m => m.ID == id);
            if (mechanic == null)
            {
                return HttpNotFound();
            }

            return View(mechanic);
        }

        // POST: Mechanics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Mechanic mechanic = _context.Mechanic.Single(m => m.ID == id);
            _context.Mechanic.Remove(mechanic);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
