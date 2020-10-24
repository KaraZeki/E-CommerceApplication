using Abc.MsSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.MsSql.Business.Abstract
{
    public interface ICategoryServices
    {
        //Not Burada temele Crud işlemleri için Generik repository den referans almıyoruz Çünkü bu katman operasyon katmanıdır 

        List<Category> GetAll();
        List<Category> GetByCategory(int categoryId);

        void Add(Category category);

        void Update(Category category);

        void Delete(int categoryId);
    }
}
