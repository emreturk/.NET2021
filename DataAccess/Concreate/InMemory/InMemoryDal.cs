//using DataAccess.Abstract;
//using Entities.Concreate;
//using Entities.Dtos;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;


//namespace DataAccess.Concreate.InMemory
//{
//    public class InMemoryDal : ICarDal
//    {
//        List<Car> _car;

//        public InMemoryDal()
//        {
//            _car = new List<Car>()
//           {
//               new Car(){Id = 1,BrandId = 1,ColorId = 1,DailyPrice = 111,Description = "1.",ModelYear = 1111},
//               new Car(){Id = 2,BrandId = 2,ColorId = 2,DailyPrice = 222,Description = "2.",ModelYear = 2222},
//               new Car(){Id = 3,BrandId = 3,ColorId = 3,DailyPrice = 333,Description = "3.",ModelYear = 3333},
//               new Car(){Id = 4,BrandId = 4,ColorId = 4,DailyPrice = 444,Description = "4.",ModelYear = 4444},
//               new Car(){Id = 5,BrandId = 5,ColorId = 5,DailyPrice = 555,Description = "5.",ModelYear = 5555}
//           };

//        }


//        public List<Car> GetById(int getCarId)
//        {
//            return _car.Where(c => c.Id == getCarId).ToList();

//        }

//        public List<Car> GetAll()
//        {
//            return _car;

//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public void Add(Car car)
//        {
//            _car.Add(car);
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
//            carToUpdate.Id = car.Id;
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.Description = car.Description;
//            carToUpdate.ModelYear = car.ModelYear;
//            carToUpdate.DailyPrice = car.DailyPrice;

//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
//            _car.Remove(carToDelete);

//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<CarRentDetailDto> GetCarDetails()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
