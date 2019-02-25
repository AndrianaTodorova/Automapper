using System;
using System.Collections.Generic;
using System.Text;

namespace TestMapper
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public ICollection<int> Stock { get; set; }
    }
}
