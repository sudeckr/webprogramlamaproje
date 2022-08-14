﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proje.Models
{
    public class OrderDetail { 
        public int Id { get; set; }
        public int? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        [NotMapped]
        public double Fee
        {
            get
            {
                return Quantity * Fee;

            }
        }

    }
}
