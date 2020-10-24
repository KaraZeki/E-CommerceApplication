using Abc.Core.DataAccess.EntityFramework;
using Abc.MsSql.DataAccess.Abstract;
using Abc.MsSql.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Abc.MsSql.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, MsSqlContext>, IProductDal
    {
       
    }
}
