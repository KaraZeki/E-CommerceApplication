using Abc.MsSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.MsSql.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemovoToCart(Cart cart, int productId);

        List<CartLine> List(Cart cart);
    }
}
