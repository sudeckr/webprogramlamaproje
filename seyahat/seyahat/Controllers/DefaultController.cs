using Microsoft.AspNetCore.Mvc;
using seyahat.Data;
using seyahat.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seyahat.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DefaultController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            var deger = _db.Blog.OrderByDescending(x=>x.Id).Take(6).ToList();
            return View(deger);
        }
        public ActionResult About()
        {
            return View();
        }
   

    }
}
