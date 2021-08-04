using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore_IL.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public int categoryID { get; set; }
        public Category category { get; set; }
    }
}
