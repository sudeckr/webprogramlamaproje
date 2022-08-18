using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using seyahat.Models.Siniflar;
using seyahat.Data;

namespace seyahat.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AboutController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            var degerler = _db.Hakkimizda.ToList();
            return View(degerler);
        }
    }
}
