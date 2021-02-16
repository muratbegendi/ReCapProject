using Core.DataAccess.EntityFramework;
using DataAccess.Abstarct;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {

            using (RentACarDBContext context = new RentACarDBContext())
            {
                var result = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars
                             on re.CarId equals ca.CarId
                             join cus in context.Customers
                             on re.CustomerID equals cus.Id
                             join us in context.Users
                             on cus.UserId equals us.Id
                             join br in context.Brands
                             on ca.BrandId equals br.BrandId
                             select new RentalDetailDto
                             {
                                 Id = re.Id,
                                 CustomerName = cus.CompanyName,
                                 CarId = ca.CarId,
                                 BrandName = br.BrandName,
                                 RentalDate = re.RentalDate,
                                 ReturnDate = re.ReturnDate,
                                 UserName = us.FirstName + " " + us.LastName
                             };

                return result.ToList();

            }
        }
}
