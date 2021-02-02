using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //Veritabanından geliyor gibi simule ediyoruz
            _cars = new List<Car> {
            new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2020, DailyPrice=250000, Description="Mercedes CLR"},
            new Car{CarId=2, BrandId=2, ColorId=2, ModelYear=2021, DailyPrice=3500000, Description="Bentley"},
            new Car{CarId=3, BrandId=3, ColorId=3, ModelYear=2019, DailyPrice=150000, Description="Range Rover"},
            new Car{CarId=4, BrandId=1, ColorId=4, ModelYear=2018, DailyPrice=100000, Description="Mercedes"},
            new Car{CarId=5, BrandId=2, ColorId=5, ModelYear=2020, DailyPrice=1000000, Description="Pontiac"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
