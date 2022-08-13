using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proje.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }


    }
}
