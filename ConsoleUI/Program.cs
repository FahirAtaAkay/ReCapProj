using System;
using System.Net.Http.Headers;
using Business.Abstract;
using Business.Concrete;
 using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;

namespace ReCapProj
{
    class Program 
    {
        static void Main(string[] args) 
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId=256, ColorId=31, CurrentPrice=756000, Description="kia ", Id=7});
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);

            //}
            

            
        }
    }
}

