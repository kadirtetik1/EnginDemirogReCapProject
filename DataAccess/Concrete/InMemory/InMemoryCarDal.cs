using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { BrandId = 1, ColorId = 1, Id = 1, ModelYear = "2015", DailyPrice = "1500$", Description = "1.16, F20, LCI" },
                new Car { BrandId = 2, ColorId = 2, Id = 2, ModelYear = "2016", DailyPrice = "1600$", Description = "3.20, F30, LCI" },
                new Car { BrandId = 3, ColorId = 3, Id = 3, ModelYear = "2017", DailyPrice = "1700$", Description = "3.35, F30, LCI" },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(Car car)
        {

            return _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);

            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;

        }
    }
}
