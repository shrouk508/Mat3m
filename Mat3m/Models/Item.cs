using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3m.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
