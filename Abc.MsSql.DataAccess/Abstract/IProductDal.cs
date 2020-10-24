using Abc.Core.DataAccess;
using Abc.MsSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Abc.MsSql.DataAccess.Abstract
{
    public interface IProductDal:IEentityRepository<Product>
    {

    }
}
