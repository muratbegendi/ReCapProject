using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBranDal : EfEntityRepositoryBase<Brand, RentACarDBContext>, IBrandDal
    {

    }
}
