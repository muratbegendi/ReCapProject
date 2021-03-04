using Business.Concrete;
using Business.Constants;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleCarUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBranDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            UserManager userManager = new UserManager(new EfUserDal());
            
            
            //UserAdded(userManager);
            //CarTest();
            //BrandTest();
        }

        //private static void UserAdded(UserManager userManager)
        //{
        //    User user = new User
        //    {
        //        FirstName = "Tuna",
        //        LastName = "Demir",
        //        Email = "tunademir@hotmail.com",
        //        Password = "123456789"
        //    };
        //    userManager.Add(user);
        //    Console.WriteLine(user.FirstName + " " + user.LastName + " başarıyla eklendi");
        //}

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBranDal());
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Model Year:" + car.ModelYear + "- " + "Description: " + car.Description + "- " + "Daily price:" + car.DailyPrice + "/" + "- " + car.BrandName + "/" + "- " + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
