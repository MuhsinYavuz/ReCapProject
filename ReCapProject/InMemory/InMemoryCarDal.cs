using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.InMemory
{
   public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId=1, ColorId=1,  ModelYear = 1999, DailyPrice=70, Description="test description"},
                new Car{Id = 2,BrandId=2, ColorId=1,  ModelYear = 2003, DailyPrice=50, Description="test description1"},
                new Car{Id = 3,BrandId=2, ColorId=3,  ModelYear = 2007, DailyPrice=90, Description="test description2"},
                new Car{Id = 4,BrandId=3, ColorId=1,  ModelYear = 2002, DailyPrice=60, Description="test description3"},


            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Id + " eklendi" );
        }

        public void Delete(int carId)
        {
            Car carToDelete = _cars.Where(tempCar => tempCar.Id == carId).First();
            _cars.Remove(carToDelete);
            Console.WriteLine(carId +" silindi");


        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("Araba Listesi : ");
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            Console.WriteLine("Car get by id.");
            return _cars.Where(tempCar => tempCar.Id == id).First();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.Where(tempCar => tempCar.Id == car.Id).First();
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            Console.WriteLine("Car is updated.");
        }

       
    }
}
