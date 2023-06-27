using ASME_Forms.Data;
using ASME_Forms.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASME_Forms.Controllers
{
    public class ASMEController : Controller
    {
        private readonly ApplicationDbContext? _db;
        public ASMEController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<ASME_CBI> objASMEList = _db.ASME_CBI.ToList();
            return View(objASMEList);
        }

        public IActionResult Create_CBI_Tank() 
        {
            return View();
        }

        public IActionResult Create_CBI_HX()
        {
            return View();
        }

        public IActionResult Create_VI()
        {
            return View();
        }
        public IActionResult Create_FI_HEADS()
        {
            return View();
        }

        public IActionResult Create_P_50I()
        {
            return View();
        }
        public IActionResult Create_TI()
        {
            return View();
        }

        public IActionResult Create_PI()
        {
            return View();
        }
    }
}
