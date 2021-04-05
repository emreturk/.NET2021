using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
//using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;
using Core.Entities.Concreate;

namespace ConsoleUITest
{
    class Program
    {
        static void Main(string[] args)
        {

            //ICarService carManager = new CarManager(new EfCarDal());
            //foreach (var c in carManager.GetAll().Data)
            //{
            //    Console.WriteLine(c.Id);
            //    Console.WriteLine(c.CarName);
            //}


            //Test1();
            //Test2();
            //test3();
            //test4();
            //Test5();
            // Test6();
            //Test7();
            //ColorTest();
            //BrandTest();
            //CarTest();
            //AddColorTest();
            //AddBrandTest();
            //AddCarTest();
            //UpdateColorTest();
            //DeleteColorTest();
            //AddBrandTest();
            //RentalManagerAdd();
            //AddUser();


        }

        //private static void AddUser()
        //{
        //    UserManager user = new UserManager(new EfUserDal());
        //    user.Add(new User
        //    { Id = 1, Email = "as.com", FirstName = "emre", LastName = "trkmen", Password = "123123" }
        //    );
        //    user.Add(new User()
        //    { Id = 2, Email = "bi.com", FirstName = "burak", LastName = "asdas", Password = "33232" });
        //}

        //private static void RentalManagerAdd()
        //{
        //    RentalManager rentalManager = new RentalManager(new EfRentalDal());
        //    var result = rentalManager.Add(
        //        new Rental
        //        {
        //            Id = 7,
        //            CarId = 3,
        //            CustomerId = 1,
        //            RentDate = new DateTime(2021, 02, 25),
        //            ReturnDate = new DateTime(2021, 03, 01)
        //        }
        //        );
        //    if (result.Success)
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}

        //private static void DeleteColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    colorManager.Delete(new Color { Id = 2, ColorName = "Beyaz" });
        //}

        //private static void UpdateColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    colorManager.Update(new Color { Id = 1, ColorName = "Kırmızı" });
        //}

        //private static void AddCarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    carManager.Add(new Car { Id = 1, BrandId = 3, ColorId = 2, CarName = "C5", ModelYear = 2017, DailyPrice = 30500, Description = "Otomatik" });
        //    carManager.Add(new Car { Id = 2, BrandId = 2, ColorId = 1, CarName = "C", ModelYear = 2020, DailyPrice = 28000, Description = "Manuel" });
        //}

        //private static void AddBrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    brandManager.Add(new Brand { Id = 1, BrandName = "Reno" });

        //}

        //private static void AddColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    colorManager.Add(new Color { Id = 6, ColorName = "Mor" });
        //    colorManager.Add(new Color { Id = 7, ColorName = "Kurşuni" });

        //}

        //private static void CarTest()
        //{
        //    CarManager carmanager = new CarManager(new EfCarDal());
        //    var result = carmanager.getCarRentDetailDtos();
        //    if (result.Success)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }


        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    var result = brandManager.GetAll();

        //    foreach (var brand in result.Data)
        //    {
        //        Console.WriteLine(brand.Id);
        //    }
        //}

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    var result = colorManager.GetAll();

        //    foreach (var color in result.Data)
        //    {
        //        Console.WriteLine(color.Id + "/" + color.ColorName);
        //    }
        //}
        //private static void Test7()
        //{
        //    ICarService car = new CarManager(new EfCarDal());
        //    car.Add(new Car()
        //    {
        //        Id = 1,
        //        BrandId = 1,
        //        ColorId = 1,
        //        CarName = "reno",
        //        DailyPrice = 1000,
        //        Description = "Açıklancakbirşeyyok",
        //        ModelYear = 2015
        //    });
        //    foreach (var a in car.GetAll().Data)
        //    {
        //        Console.WriteLine(a.CarName);
        //    }
        //}

        //private static void Test6()
        //{
        //    CustomerManager customer1 = new CustomerManager(new EfCustomerDal());
        //    customer1.Add(new Customer
        //    {
        //        UserId = 1,
        //        CompanyName = "Stechome"
        //    });
        //}

        //private static void Test5()
        //{
        //    ICarService carRent = new CarManager(new EfCarDal());

        //    var result = carRent.getCarRentDetailDtos();
        //    if (result.Success)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine("{0}++{1}++{2}++{3}++", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result);
        //    }
        //}


        //private static void test4()
        //{
        //    ICarService carRent = new CarManager(new EfCarDal());

        //    carRent.Add(new Car
        //    { Id = 5, BrandId = 4, ColorId = 4, DailyPrice = 2222, Description = "ferrari", ModelYear = 20220 });
        //    foreach (var c in carRent.GetAll().Data)
        //    {
        //        Console.WriteLine(c.Id + "///" + c.DailyPrice);
        //    }
        //}

        //private static void test3()
        //{
        //    IBrandService brand = new BrandManager(new EfBrandDal());
        //    foreach (var a in brand.GetAll().Data)
        //    {
        //        Console.WriteLine(a.Id + " // " + a.BrandName);
        //    }
        //}

        //private static void Test2()
        //{
        //    IColorService carManager3 = new ColorManager(new EfColorDal());
        //    foreach (var c in carManager3.GetAll().Data)
        //    {
        //        Console.WriteLine(c.Id);
        //        Console.WriteLine(c.ColorName);
        //    }
        //}

        //private static void Test1()
        //{
        //    ICarService carRent = new CarManager(new InMemoryDal());

        //    foreach (var c in carRent.GetAll().Data)
        //    {
        //        Console.WriteLine(c.BrandId);
        //        Console.WriteLine(c.Id);
        //        Console.WriteLine(c.ColorId);
        //        Console.WriteLine(c.DailyPrice);
        //        Console.WriteLine(c.Description);
        //        Console.WriteLine(c.ModelYear);
        //    }

        //    Console.WriteLine(carRent.GetAll());
        //}
    }



}



