using Abc.MsSql.Business.Abstract;
using Abc.MsSql.DataAccess.Abstract;
using Abc.MsSql.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.MsSql.Business.Concrete
{
    public class ProductManager : IProductServices
    {

        //NoT BU işlem SOLID prensibinin D sine (Dependecy Injection) Uygunbdur.


        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Product {Id= productId });
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId ==categoryId || categoryId==0);  
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p=>p.Id==productId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}

