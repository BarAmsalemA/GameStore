using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore_IL.Models
{
    public class Category
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public List<Product> products { get; set; }
    }
}
