using ASME_Forms.Data;
using ASME_Forms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASME_Forms.Controllers
{
    public class ASMEController : Controller
    {
        private readonly ApplicationDbContext? _db;
        public ASMEController(ApplicationDbContext db)
        {
            _db = db;
        }

        //CBI Tank Index Page
        public IActionResult Index()
        {
            List<ASME_CBI> objASMEList = _db.ASME_CBI.ToList();
            return View(objASMEList);
        }

        //CBI HX Index Page
        public IActionResult Index_HX()
        {
            List<ASME_CBI_HX> objASMEList = _db.ASME_CBI_HX.ToList();
            return View(objASMEList);
        }

        //Create CBI Tanks
        public IActionResult Create_CBI_Tank() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create_CBI_Tank(ASME_CBI obj)
        {

            _db.ASME_CBI.Add(obj);
            _db.SaveChanges();
            TempData["Success"] = "ASME From Created Successfully";
            return RedirectToAction("Index");
        }

        //Create CBI HX
        public IActionResult Create_CBI_HX()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create_CBI_HX(ASME_CBI_HX obj1)
        {

            _db.ASME_CBI_HX.Add(obj1);
            _db.SaveChanges();
            TempData["Success"] = "ASME From Created Successfully";
            return RedirectToAction("Index");
        }

    }
}
