using DataAccess.Abstarct;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBranDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Brand entity)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        Brand IEntityRepository<Brand>.Get(Expression<Func<Brand, bool>> filter)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        List<Brand> IEntityRepository<Brand>.GetAll(Expression<Func<Brand, bool>> filter)
        {
            using (RentACarDBContext context = new RentACarDBContext())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }
    }
}
