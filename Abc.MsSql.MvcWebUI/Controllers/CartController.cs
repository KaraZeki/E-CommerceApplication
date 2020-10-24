using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.MsSql.Business.Abstract;
using Abc.MsSql.Entities.Concrete;
using Abc.MsSql.MvcWebUI.Moddels;
using Abc.MsSql.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Abc.MsSql.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartSessionService _cartSessionService;
        private IProductServices _productServices;
        public CartController(
        ICartService cartService,
        ICartSessionService cartSessionService,
        IProductServices productServices)
        {
            _cartService = cartService;
            _cartSessionService = cartSessionService;
            _productServices = productServices;
        }

        public IActionResult AddToCart(int productId)
        {
            var prodctToBeAdded = _productServices.GetById(productId);
            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart, prodctToBeAdded);
            _cartSessionService.SetCard(cart);

            TempData.Add("message", string.Format("Your product ,{0}, was successfully added to the cart!", prodctToBeAdded.ProductName));
            return RedirectToAction("Index","Product");
        }
        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();

            CartSummaryViewModel cartSummaryViewModel = new CartSummaryViewModel()
            {
                Cart = cart
            };
            return View(cartSummaryViewModel);
        }
        public IActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemovoToCart(cart, productId);
            _cartSessionService.SetCard(cart);
            TempData.Add("message", string.Format("Your product  was successfully removed  from the cart!"));
            return RedirectToAction("List");
        }

        public IActionResult Complate()
        {
            var shippingDetailsViewModel = new ShippingDetailsVİewModel()
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }


        [HttpPost]
        public IActionResult Complate(ShippingDetails shippingDetails)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            TempData.Add("message",string.Format("Thenk you,{0}, your order is in process", shippingDetails.FirstName));

            var shippingDetailsViewModel = new ShippingDetailsVİewModel()
            {
                ShippingDetails = new ShippingDetails()
            };
            return View(shippingDetailsViewModel);
        }
    }
}