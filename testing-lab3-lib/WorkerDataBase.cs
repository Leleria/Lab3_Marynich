sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testing_lab3.DataBase;

namespace testing_lab3
{
    public class WorkerDataBase
    {
        ApplicationContext db = new ApplicationContext();
        public void AddData(string login, string password, string repeatPassword, string result, string messageError)
        {

            User user = new User(login, password, repeatPassword, result, messageError);
            db.Users.Add(user);
            db.SaveChanges();
        }
        public List<User> GetData()
        {
            return db.Users.ToList();
        }
        public void DeleteData(string login, string password, string repeatPassword)
        {
            var user = db.Users.Where(x => x.login == login && x.password == password && x.repeatPassword == repeatPassword).First();
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}
