﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proje.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public double Quantity{ get; set; }
        public Customer Customer { get; set; }
        public double Price { get; set; }
        public bool OrderOk { get; set; } = false;
        [NotMapped]
        public double Fee
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}
