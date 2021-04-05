using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concreate.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentContext>, ICarDal
    {
        public List<CarRentDetailDto> GetCarDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result =
                    from c in context.Cars
                    join co in context.Colors on
                    c.ColorId equals co.ColorId
                    join b in context.Brands on
                        c.BrandId equals b.BrandId
                    select new CarRentDetailDto
                    {
                        CarName = c.CarName,
                        BrandName = b.BrandName,
                        ColorName = co.ColorName,
                        DailyPrice = c.DailyPrice
                    };
                return result.ToList();

            }
        }


    }
}
