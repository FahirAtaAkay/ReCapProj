using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car=new List<Car>();
        public InMemoryCarDal()
        {
            _car = new List<Car> { new Car { Id = 5, BrandId = 2003, ColorId = 2002, CurrentPrice = 560000, Description = "mazda speed" } };
            
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            
             Car carToDelete =_car.SingleOrDefault(p=>p.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(p => p.Id == id).ToList();
           
        }

        public void Update(Car car)
        {
            
            Car carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CurrentPrice = car.CurrentPrice;
            carToUpdate.Description = car.Description;

            
        }
    }
}
