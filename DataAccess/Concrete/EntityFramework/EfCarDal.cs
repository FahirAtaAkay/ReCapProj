using System;
using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Entities.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            if(entity.BrandId.ToString().Length < 2) 
            {
                Console.WriteLine("BrandId must contain at leas two digits ");
                return;
            }
             if(entity.ColorId.ToString().Length < 2)
            {
                Console.WriteLine("ColorId must contain at least two characters");
                return;
            }
        
            using (FahirakayDbContext context = new FahirakayDbContext()) 
            {
                
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (FahirakayDbContext context = new FahirakayDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (FahirakayDbContext context = new FahirakayDbContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
               
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (FahirakayDbContext context = new FahirakayDbContext())
            {
                return filter == null ? context.Set<Car>().ToList(): context.Set<Car>().Where(filter).ToList();


            }
        }

        public void Update(Car entity)
        {
            using (FahirakayDbContext context = new FahirakayDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
