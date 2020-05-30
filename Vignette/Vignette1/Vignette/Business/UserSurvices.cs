using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vignette.Data;
using Vignette.Data.Model;

namespace Business
{
    public class UserSurvices
    {
        public List<User> GetAll()
        {
            List<User> user = null;
            using (var context = new VignetteContext())
            {
                user = context.Users.ToList();
            }
            return user;
        }
        public User GetByCar(Car car)
        {
            User user = null;
            using (var context = new VignetteContext())
            {
                user = context.Users.FirstOrDefault(u => u.Id == car.Id_User );
            }
            return user;
        }
        public void takeData(User user)
        {
            using (var context = new VignetteContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
