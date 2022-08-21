using Microsoft.AspNetCore.Mvc;
using seyahat.Data;
using seyahat.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seyahat.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var deger = _db.Blog.ToList();
            return View(deger);
        }
        [HttpGet]//sayfa yüklendiğinde
        public IActionResult BlogEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BlogEkle(Blog b)
        {
            _db.Blog.Add(b);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BlogSil(int id)
        {
            var b = _db.Blog.Find(id);
            _db.Blog.Remove(b);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
