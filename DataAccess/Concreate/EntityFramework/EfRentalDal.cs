using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentContext>, IRentalDal
    {
        //rental - car - customer - user
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {

                var result = from r in context.Rentals
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
                                 BrandName = b.BrandName,
                                 RentDate = r.RentDate.Value,
                                 ReturnDate = r.RentDate.Value,
                                 CarId = c.CarId,
                                 CustomerName = $"{ u.FirstName} {u.LastName }"
                             };

                return result.ToList();
            }
        }
    }
}
