using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.InMemory;
using Entities;
using System;
using System.Collections.Generic;

namespace ConcoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            ICarDal inMemoryCarDal = new InMemoryCarDal();
           // ICarService carManager = new carManager(inMemoryCarDal);

            // Get All Cars
       //     List<Car> cars = carManager.GetAll();

            // Add new car
            Car testCar = new Car { Id = 10, BrandId = 3, ColorId = 2, DailyPrice = 100, Description = "new car", ModelYear = 2015 };
       //     carManager.Add(testCar);
           // printCars(cars);


            // Get car by id
            Car carToGet = carManager.GetById(10);
            Console.WriteLine(carToGet.ToString());


            // Update a car
            Car updatedCar = new Car { Id = 7, BrandId = 5, ColorId = 9, DailyPrice = 80, Description = "updated car", ModelYear = 2015 };
         //   carManager.Update(testCar.Id, updatedCar);
            printCars(cars);

            // Delete a car
         //   carManager.Delete(testCar.Id);
            printCars(cars);

        }
        // Print all cars
        static void printCars(List<Car> cars)
        {
            foreach (Car tempCar in cars)
            {
                Console.WriteLine(tempCar.Id.ToString() +" " +  tempCar.BrandId.ToString() + " " + tempCar.ColorId.ToString() + " " + tempCar.DailyPrice.ToString() + " " + tempCar.Description.ToString());
              
            }
            Console.WriteLine();
       
            */
            Update();

            Add();

            Delate();

            GetAll();

            GetById();
        }
            public  static void GetById()
            {
                CarManager carManeger = new CarManager(new EfCarDal());

                carManeger.GetById(3);

            }

            public static void GetAll()
            {
                CarManager carManeger = new CarManager(new EfCarDal());

                foreach (var c in carManeger.GetAll())
                {
                    Console.WriteLine(c.Id + "-" + c.Description );
                }
            }

            public static void Delate()
            {
                Car car = new Car { Id = 2 };
                CarManager carManeger = new CarManager(new EfCarDal());
                carManeger.Delete(car);
                
            }

            public  static void Add()
            {
                Car car = new Car { Id = 10, BrandId = 1, ColorId = 1, ModelYear = 2012, DailyPrice = 200000, Description = "temiz" };
                CarManager carManeger = new CarManager(new EfCarDal());
                carManeger.Add(car);
                
            }

            public static void Update()
            {
                Car car = new Car { Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2012 , DailyPrice = 200, Description = "temiz" };
                CarManager carManeger = new CarManager(new EfCarDal());
                carManeger.Update(car);
               
            }
        } 
    }
    

