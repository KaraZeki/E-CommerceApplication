using Abc.MsSql.Entities.Concrete;
using Abc.MsSql.MvcWebUI.ExtentionMetods;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.MsSql.MvcWebUI.Services
{
    public class CartSessionManager : ICartSessionService
    {


        IHttpContextAccessor _httpContextAccessor; //Not bu yapıyı cullanmazsak session u bu class içinde kullanamayız. Çünkü session sadece Controller larda kullanılır 
        public CartSessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Cart GetCart()
        {
           Cart cartToCheck= _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToCheck==null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cartToCheck;
        }

        public void SetCard(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject("cart",cart);
        }
    }
}
