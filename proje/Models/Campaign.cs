using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proje.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Beginning { get; set; }
        public DateTime Finish { get; set; }
        public double Ratio { get; set; }
        public double Min { get; set; }
    }
}
