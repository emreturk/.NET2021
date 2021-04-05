using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using System.Collections.Generic;

namespace Business.Concreate
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandRentDal;

        public BrandManager(IBrandDal brandRentDal)
        {
            _brandRentDal = brandRentDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {

            return new SuccessDataResult<List<Brand>>(_brandRentDal.GetAll());

        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandRentDal.Get(p => p.BrandId == id));
        }


        public IResult Add(Brand brand)
        {
            _brandRentDal.Add(brand);
            return new SuccessResult("Marka eklendi");
        }

        public IResult Update(Brand brand)
        {
            _brandRentDal.Update(brand);
            return new SuccessResult("güncellendi");
        }

        public IResult Delete(Brand brand)
        {
            _brandRentDal.Delete(brand);
            return new SuccessResult("Silindi");
        }
    }
}
