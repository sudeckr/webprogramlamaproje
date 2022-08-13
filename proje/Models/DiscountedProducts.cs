using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proje.Models
{
    public class DiscountedProducts
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public DateTime Beginning { get; set; }
        public DateTime Finish { get; set; }
        public double Ratio { get; set; }
        public bool OtherDiscount { get; set; } = true;


    }
}
