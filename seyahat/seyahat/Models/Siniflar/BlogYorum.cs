using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seyahat.Models.Siniflar
{
    public class BlogYorum
    {
        public int Id { get; set; }
        public IEnumerable<Blog> Deger { get; set; } //bir view içinde birden çok tablo içinden veri çekebilicem
        public IEnumerable<Yorumlar> Deger2 { get; set; }
    }
}
