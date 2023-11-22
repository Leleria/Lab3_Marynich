using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab3
{
    public class Email
    {
        public string Message(bool dataBase)
        {
            string message;
            if (dataBase)
                message = "Данные получены из базы данных";
            else message = "Данные получены из базы данных";

            return message;
        }
    }
}
