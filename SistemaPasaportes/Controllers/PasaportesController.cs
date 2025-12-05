using System.Linq;
using System.Web.Mvc;
using SistemaPasaportes.Data;
using SistemaPasaportes.Models;

namespace SistemaPasaportes.Controllers
{
    public class PasaportesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Pasaportes (Lista todos)
        [HttpGet]
        public ActionResult Index()
        {
            var pasaportes = db.Pasaportes.ToList();
            return View(pasaportes);
        }

        // GET: Pasaportes/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pasaportes/Create
        [HttpPost]
        public ActionResult Create(Pasaporte pasaporte)
        {
            if (ModelState.IsValid)
            {
                db.Pasaportes.Add(pasaporte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pasaporte);
        }

        // GET: Pasaportes/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            var pasaporte = db.Pasaportes.Find(id);
            if (pasaporte == null)
            {
                return HttpNotFound();
            }
            return View(pasaporte);
        }

        // POST: Pasaportes/Edit/5
        [HttpPost]
        public ActionResult Edit(Pasaporte pasaporte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pasaporte).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pasaporte);
        }

        // POST: Pasaportes/Delete/5 (Eliminar directo)
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            var pasaporte = db.Pasaportes.Find(id);
            if (pasaporte != null)
            {
                db.Pasaportes.Remove(pasaporte);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}