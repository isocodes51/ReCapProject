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

            carManager.Add(new Car {
                BrandId=1, ColorId=1, Name="Mercedes", ModelYear="2016", DailyPrice=10000, Description="Mercedes C200 GLA"  
                });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}
