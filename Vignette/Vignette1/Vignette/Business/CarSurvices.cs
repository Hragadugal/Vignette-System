using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vignette.Data;
using Vignette.Data.Model;

namespace Business
{
    public class CarSurvices
    {
        public List<Car> GetAll()
        {
            List<Car> cars = null;
            using (var context = new VignetteContext())
            {
                cars = context.Cars.ToList();
            }
            return cars;

        }
        public Car GetByCarRegistration(string carRegistration)
        {
            Car car = new Car();
            using (var context = new VignetteContext())
            {
                car = context.Cars.FirstOrDefault(c => c.CarRegistration == carRegistration);
            }
            return car;
        }
        public void takeData(Car cars)
        {
            using (var context = new VignetteContext())
            {
                context.Cars.Add(cars);
                context.SaveChanges();
            }
        }











        //      using (SqlConnection connection = new SqlConnection(connectionString))
        //using (SqlCommand command = new SqlCommand("select * from Requests where Complete = 0", connection))
        //{
        //    connection.Open();
        //    using (SqlDataReader reader = command.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            Console.WriteLine(reader["Username"].ToString());
        //            Console.WriteLine(reader["Item"].ToString());
        //            Console.WriteLine(reader["Amount"].ToString());
        //            Console.WriteLine(reader["Complete"].ToString());
        //        }
        //    }
        //}
        //public List<BoughtVignette> GetAll()
        //{
        //    List<BoughtVignette> boughtVignettes = null;
        //    using (var context = new VignetteContext())
        //    {
        //        boughtVignettes = context.BoughtVignettes.ToList();
        //    }
        //    return boughtVignettes;
        //}

        //public List<BoughtVignette> GetCarRegistration(string carRegistration)
        //{
        //    List<BoughtVignette> boughtVignettes = null;
        //    using (var context = new VignetteContext())
        //    {
        //        boughtVignettes = context.BoughtVignettes.Where(b => b.cars.CarRegistration == carRegistration).ToList();
        //    }
        //    return boughtVignettes;
        //}



        //public void Add()
        //{
        //    List<BoughtVignette> boughtVignettes = null;
        //    using (var context = new VignetteContext())
        //    {
        //        boughtVignettes = context.BoughtVignettes.ToList();
        //    }
        //    return boughtVignettes;
        //}
    }
}
