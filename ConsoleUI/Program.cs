using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var _car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(_car.BrandId);
            //}

            //Add(carManager);
            //Delete(carManager);
            Update(carManager);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}", car.Name);
            }
        }

        private static void Update(CarManager carManager)
        {
            carManager.Update(new Car
            {
                Id = 4,
                BrandId = 2,
                ColorId = 1,
                Name = "Mercedes",
                DailyPrice = 1000,
                Description = "Mercedes E 200",
                ModelYear = "2018"
            });
        }

        private static void Delete(CarManager carManager)
        {
            carManager.Delete(new Car { Id = 2 });
        }

        private static void Add(CarManager carManager)
        {
            carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 1,
                Name = "Bugatti",
                ModelYear = "2021",
                DailyPrice = 0,
                Description = "Bugatti Veyron"
            });
        }
    }
}
