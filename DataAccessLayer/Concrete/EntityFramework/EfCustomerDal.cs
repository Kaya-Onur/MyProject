using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete.EntityFramework
{
    class EfCustomerDal : EfEntityRepositoryBase<Customer, Context>, ICustomerDal
    {
    }
}
