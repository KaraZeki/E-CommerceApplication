using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.MsSql.Business.Abstract;
using Abc.MsSql.Entities.Concrete;
using Abc.MsSql.MvcWebUI.Moddels;
using Microsoft.AspNetCore.Mvc;

namespace Abc.MsSql.MvcWebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductServices _productServices;
        private ICategoryServices _categoryServices;
        public AdminController(IProductServices productServices, ICategoryServices categoryServices)
        {
            _productServices = productServices;
            _categoryServices = categoryServices;
        }
        public IActionResult Index()
        {
            var productListViewModel = new ProductListViewModel()
            {
                Products = _productServices.GetAll(),
            };
            return View(productListViewModel);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryServices.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _productServices.Add(product);

            TempData.Add("message", string.Format("Product was successfully added"));

            return RedirectToAction("Add");
        }



        public IActionResult Update(int productId)
        {
            var productUpdateViewModel = new ProductUpdateViewModel()
            {
                Product = _productServices.GetById(productId),
                Categories = _categoryServices.GetAll()
            };
            return View(productUpdateViewModel);
        }
            

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _productServices.Update(product);
            TempData.Add("message", string.Format("Product was successfully added"));
            return RedirectToAction("Update");
        }

        
        public IActionResult Delete(int productId)
        {
            _productServices.Delete(productId);
            TempData.Add("message", string.Format("Your product ,{0}, is deleted!!", productId));
            return RedirectToAction("Index");
        }
    }
}