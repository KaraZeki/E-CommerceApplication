using Abc.MsSql.Business.Abstract;
using Abc.MsSql.MvcWebUI.Moddels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.MsSql.MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent //burada isimlendirme ViewComponent ile bitmesi gerek.
    {
        ICategoryServices _categoryServices;
        public CategoryListViewComponent(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public IViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryServices.GetAll(),
                CurrentCategory =Convert.ToInt32(HttpContext.Request.Query["categoryId"])
            };
            return View(model);
        }
    }
}
