using Microsoft.AspNetCore.Mvc;
using ClientCatalog.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClientCatalog.Controllers
{
    public class StylistsController : Controller
    {
        private readonly ClientCatalogContext _db;

        public StylistsController(ClientCatalogContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.ToList();
            ViewBag.ClientName = _db.Clients;
            return View(model);
            // This didn't seem to work
            // List<Stylist> model = _db.Stylists.Include(stylists => StylistsController.clients).ToList();
            // return View(model);
        }

        //hopefully make a viewbag to fix my clients not showing up
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Stylist stylist)
        {
            _db.Stylists.Add(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            ViewBag.thisStylistClients = _db.Clients.Where(Client => Client.StylistId == id);
            return View(thisStylist);

            //  var thisStylist = _db.Stylists
            //     .Include(stylist => stylist.Clients)
            //     .ThenInclude(join => join.Client)
            //     .FirstOrDefault(stylist => stylist.StylistId == id);
            // return View(thisStylist);
        }


        public ActionResult Edit(int id)
        {
            var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            return View(thisStylist);
        }

        [HttpPost]
        public ActionResult Edit(Stylist stylist)
        {
            _db.Entry(stylist).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            return View(thisStylist);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            _db.Stylists.Remove(thisStylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}