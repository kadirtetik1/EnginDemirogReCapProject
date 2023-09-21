
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//Console.WriteLine("Hello, World!");


//Car car = new Car();

//car.BrandId = 1;
//car.Description = "Test";
//car.Id = 2;
//car.ModelYear = "1997";
//car.ColorId = 3;
//car.DailyPrice = "1500$";


//Console.WriteLine(car.DailyPrice);
//
//sss
CarManager carManager = new CarManager(new InMemoryCarDal());  // Burayı anlamadım...

foreach (var car in carManager.GetAll())
{
    Console.WriteLine("Fiyatı:" + car.DailyPrice);
}

