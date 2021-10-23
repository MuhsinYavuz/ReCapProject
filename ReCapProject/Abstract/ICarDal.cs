using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        /*
        Car GetById(int id);

        List<Car> GetAll();

        void Add(Car car);

        void Update(int carId, Car updatedCar);

        void Delete(int carId);
        */
        // List<Car> GetCarDetails();
    }
}
