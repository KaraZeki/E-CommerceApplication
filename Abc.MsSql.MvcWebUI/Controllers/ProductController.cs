using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.MsSql.Business.Abstract;
using Abc.MsSql.MvcWebUI.Moddels;
using Microsoft.AspNetCore.Mvc;

namespace Abc.MsSql.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {

        IProductServices _producServices;
        public ProductController(IProductServices producServices)
        {
            _producServices = producServices;
        }

        public IActionResult Index(int page=1, int category=0)
        {
            int pageSize = 5;

            var products = _producServices.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page
            };
            return View(model);
        }


        public IActionResult AddToCart()
        {
            return View();
        }
    }
}