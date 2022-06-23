using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3m.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Titel { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
