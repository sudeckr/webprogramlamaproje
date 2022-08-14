using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proje.Models
{
    public class Foto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
