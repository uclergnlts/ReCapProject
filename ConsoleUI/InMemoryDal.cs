using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryDal()
        {
            _cars = new List<Car>
            {
            new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 90, Description = "Renault" },
            new Car { CarId = 2, BrandId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = 100, Description = "Renault"},
            new Car { CarId = 3, BrandId = 3, ColorId = 1, ModelYear = 2019, DailyPrice = 85, Description = "Fiat"},
            new Car { CarId = 4, BrandId = 1, ColorId = 3, ModelYear = 2018, DailyPrice = 75, Description = "Opel"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrand(int brandId)
        {
            throw new System.NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == c.CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        Car ICarDal.GetById(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}