using System;
using System.Collections.Generic;
using System.Text;

namespace TestMapper
{
    public class ProductDTO
    {
        public string Name { get; set; }


        public ICollection<int> Stock { get; set; }
    }
}
