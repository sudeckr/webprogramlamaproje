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
        public DateTime OrderDate { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string CargoCompany { get; set; }
        public double ShippingCost { get; set; }
        public double TotalFee { get; set; }
        public double Sale { get; set; }
        public SiparisDurumu SiparisDurumu { get; set; }
        public OdemeDurumu OdemeDurumu { get; set; }
        public string Code { get; set; }
        public string ShippingTrackingNo { get; set; }
        public string Explanation { get; set; }


    }
    public enum SiparisDurumu
    {
        Hazirlaniyor,
        KargoyaVerildi,
        TeslimEdildi,
        İadeEdildi
    }
    public enum OdemeDurumu
    {
        KrediKarti,
        kapidaodeme,
        Havale
    }
}
