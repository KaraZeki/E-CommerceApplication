using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.MsSql.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
