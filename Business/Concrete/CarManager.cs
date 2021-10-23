using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

       
            ICarDal _carDal;
            public CarManager(ICarDal carDal)
            {
                _carDal = carDal;
            }


            public void Add(Car car)
            {
                _carDal.Add(car);
                if (car.Description.Length > 2 && car.DailyPrice > 0)
                {
                    Console.WriteLine(car.Id + "=No Idli araba eklendi");
                }

                else
                {
                    Console.WriteLine(car.Id + "=no Idlı araba eklenemedı");
                }
            }

            public void Delete(Car car)
            {
                _carDal.Delete(car);
                Console.WriteLine(car.Id + "=No Idli araba silindi");
            }
        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.Id + " =No Idli araba güncellendi");
        }

        public List<Car> GetAll()
            {
                return _carDal.GetAll();
            }

            public Car GetById(int carId)
            {
                return _carDal.Get(c => c.Id == carId);
            }

            

           

        }
    }
