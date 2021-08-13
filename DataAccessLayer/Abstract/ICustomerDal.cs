using Core.DataAccess;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
