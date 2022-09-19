﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var _car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(_car.BrandId);
            }
        }
    }
}
