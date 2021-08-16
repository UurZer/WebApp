using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ApplicationTypesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationTypesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ApplicationType> objList = _db.ApplicationTypes;

            return View(objList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType applicationType)
        {
            _db.ApplicationTypes.Add(applicationType);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
