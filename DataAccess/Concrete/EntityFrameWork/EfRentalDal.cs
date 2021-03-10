using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDataContext>, IRentalDal
    {
        public List<RentalDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapDataContext context = new ReCapDataContext())
            {
                using (ReCapDataContext Context = new ReCapDataContext())
                {
                    var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                                 join c in context.Cars
                                 on r.CarId equals c.CarId
                                 join cu in context.Customers
                                 on r.CustomerId equals cu.CustomerId
                                 join b in context.Brands
                                 on c.BrandId equals b.BrandId
                                 join u in context.Users
                                 on cu.UserId equals u.UserId
                                 select new RentalDetailDto
                                 {
                                     RentalId = r.RentalId,
                                     CarName = b.BrandName,
                                     CompanyName = cu.CompanyName,
                                     UserName = u.FirstName + " " + u.LastName,
                                     RentDate = r.RentDate,
                                     ReturnDate = r.ReturnDate
                                 };

                    return result.ToList();






                }
            }
        }
    }
}
