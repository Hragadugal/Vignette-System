using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vignette.Data;
using Vignette.Data.Model;

namespace Business
{
    public class VinetteSurvices
    {
        public List<BoughtVignette> GetAll()
        {
            List<BoughtVignette> boughtVignettes = null;
            using (var context = new VignetteContext())
            {
                boughtVignettes = context.BoughtVignettes.ToList();
            }
            return boughtVignettes;
        }
        //Get bought vignette by car from db
        public BoughtVignette GetByCar(Car car)
        {
            BoughtVignette boughtVignettes = null;
            using (var context = new VignetteContext())
            {
                boughtVignettes = context.BoughtVignettes.FirstOrDefault(b => b.Id_Car == car.Id);
            }
            return boughtVignettes;
        }
        //Take date 
        public void takeData(BoughtVignette boughtVignettes, User user, Car car)
        {
            using (var context = new VignetteContext())
            {

                context.Users.Add(user);
                car.user = user;
                car.Id_User = user.Id;
                context.Cars.Add(car);
                boughtVignettes.Id_Car = car.Id;
                boughtVignettes.cars = car;
                context.BoughtVignettes.Add(boughtVignettes);
                context.SaveChanges();
            }
        }
        //Deleated information from base
        public void DeleteData(BoughtVignette boughtVignettes, User user, Car car)
        {
            using (var context = new VignetteContext())
            {
                User removeUser = context.Users.FirstOrDefault(u => u.FirstName == user.FirstName &&
                    u.LastName == user.LastName && u.PersonalCode == user.PersonalCode);
                Car removeCar = context.Cars.FirstOrDefault(c => c.Id_User == removeUser.Id
                    && c.CarRegistration == car.CarRegistration);
                BoughtVignette removeBoughtVignette = context.BoughtVignettes.FirstOrDefault(b => b.Id_Car == removeCar.Id
                    && b.VignettesId == boughtVignettes.VignettesId);
                //car.user = user;
                //car.Id_User = user.Id;
                //boughtVignettes.Id_Car = car.Id;
                //boughtVignettes.cars = car;
                context.Users.Remove(removeUser);
                context.Cars.Remove(removeCar);
                context.BoughtVignettes.Remove(removeBoughtVignette);
                context.SaveChanges();

            }

        }
    }
}
