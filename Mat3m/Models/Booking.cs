using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3m.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int TableNumber { get; set; }
        public DateTime DateTime { get; set; }
    }
}
