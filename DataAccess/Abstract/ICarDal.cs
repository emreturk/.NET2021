using Core.DataAccess;
using Entities.Concreate;
using Entities.Dtos;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarRentDetailDto> GetCarDetails();

    }
}
