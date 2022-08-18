using Microsoft.AspNetCore.Mvc;
using seyahat.Data;
using seyahat.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seyahat.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _db;
        public BlogController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var bloglar = _db.Blog.ToList();
            return View(bloglar);
        }
        BlogYorum by = new BlogYorum();
        public IActionResult BlogDetay(int id)
        {

            //var bul = _db.Blog.Where(x => x.Id == id).ToList();
            by.Deger = _db.Blog.Where(x => x.Id == id).ToList();
            by.Deger2 = _db.Yorumlar.Where(x => x.BlogId == id).ToList();
            return View(by);
        }

    }
}
