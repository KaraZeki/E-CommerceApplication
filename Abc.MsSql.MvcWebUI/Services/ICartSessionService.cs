using Abc.MsSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.MsSql.MvcWebUI.Services
{
   public  interface ICartSessionService
    {
        Cart GetCart();
        void SetCard( Cart cart);
    }
}
