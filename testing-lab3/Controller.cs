using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab3
{
    public class Controller
    {
        IUserInterface _userInterface;
        WorkerDataBase _database = new WorkerDataBase();
        Email email = new Email();
        public Controller(IUserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        public (string, string, string, string, string) Check()
        {
            (string, string, string, string, string) result;
            var data = _userInterface.GetRegistrationData();
            var dataInDb = _database.GetData();
            if (dataInDb.Where(x => x.Login == data[0] && x.Password == data[1] && x.RepeatPassword == data[2]).Count() != 0)
            {
                email.Message(true);
                result.Item1 = dataInDb.Where(x => x.Login == data[0] && x.Password == data[1] && x.RepeatPassword == data[2]).First().Login;
                result.Item2 = dataInDb.Where(x => x.Login == data[0] && x.Password == data[1] && x.RepeatPassword == data[2]).First().Password;
                result.Item3 = dataInDb.Where(x => x.Login == data[0] && x.Password == data[1] && x.RepeatPassword == data[2]).First().RepeatPassword;
                result.Item4 = dataInDb.Where(x => x.Login == data[0] && x.Password == data[1] && x.RepeatPassword == data[2]).First().Result;
                result.Item5 = dataInDb.Where(x => x.Login == data[0] && x.Password == data[1] && x.RepeatPassword == data[2]).First().MessageError;

                return result;
            }
            else
            {
                email.Message(false);

                Registration registration = new Registration();
               (string, string) resultReg =  registration.CheckRegistration(data[0], data[1], data[2]);

                if(resultReg == ("True", ""))
                {
                    _database.AddData(data[0], data[1], data[2], resultReg.Item1, resultReg.Item2);

                    return (data[0], data[1], data[2], resultReg.Item1, resultReg.Item2);
                }
                else
                {
                    _database.AddData(data[0], data[1], data[2], resultReg.Item1, resultReg.Item2);

                    return (data[0], data[1], data[2], resultReg.Item1, resultReg.Item2);
                }

            }
        }
    }
}
