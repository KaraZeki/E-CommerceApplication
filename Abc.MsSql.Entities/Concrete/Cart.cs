using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.MsSql.Entities.Concrete
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<CartLine>(); //bunu yapmazsak ilk listte onject referans null hatası alrırız
        }
        public List<CartLine> CartLines { get; set; }
        public decimal Total
        {
            get { return CartLines.Sum(c => c.Product.UnitPrice * c.Quantity); }
        }
    }
}
