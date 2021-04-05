using Core.Utilities.Results;
using Entities.Concreate;
using Entities.Dtos;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarRentDetailDto>> getCarRentDetailDtos();
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int productID);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IResult AddTransactionalTest(Car car);
        IDataResult<List<Car>> GetByBrandId(int id);
    }
}
