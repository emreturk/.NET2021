
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Performance;
using System.Threading;
using System.Linq;

namespace Business.Concreate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }
        public IDataResult<List<CarRentDetailDto>> getCarRentDetailDtos()
        {
            return new SuccessDataResult<List<CarRentDetailDto>>(_carDal.GetCarDetails());
        }
        //[ValidationAspect(typeof(Car))]


        //[CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "Ürünler listelendi");
        }



        //[SecuredOperation("caradd,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }
        //[CacheRemoveAspect("ICarService.Get")]
        //[ValidationAspect(typeof(Car))]
        public IResult Update(Car car)
        {
            return new SuccessResult("başarıyla Güncellendi");


        }
        // [ValidationAspect(typeof(Car))]
        public IResult Delete(Car car)
        {
            return new SuccessResult("başarıyla silindi");

        }
        //[ValidationAspect(typeof(Car))]
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == id));
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 15)
            {
                throw new Exception("");

            }
            Add(car);
            return null;
        }

        public IDataResult<List<Car>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));

        }

    }
}
