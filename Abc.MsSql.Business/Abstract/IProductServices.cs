using Abc.MsSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.MsSql.Business.Abstract
{
   public  interface IProductServices
    {
        //Not Burada temele Crud işlemleri için Generik repository den referans almıyoruz Çünkü bu katman operasyon katmanıdır 

        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);

        void Add(Product product);

        void Update(Product product);

        void Delete(int productId);
        Product GetById(int productId);
    }
}
