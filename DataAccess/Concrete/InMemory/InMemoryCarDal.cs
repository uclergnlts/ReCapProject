using DataAccess.Abstract;
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

            _cars = new List<Car> {

                new Car {CarId=1, BrandId=1, ColorId=1, ModelYear=2021, DailyPrice=200000, Description="Mercedes"},
                new Car {CarId=2, BrandId=1, ColorId=2, ModelYear=2020, DailyPrice=180000, Description= "Audi"},
                new Car {CarId=3, BrandId=2, ColorId=3, ModelYear=2019, DailyPrice=150000, Description= "BMW" },
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

        public List<Car> GetByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public Car GetById(int carId)
        {
            Car carById = _cars.SingleOrDefault(c => c.CarId == carId);
            return carById;
        }

        public void Update(Car car)
        {


            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}