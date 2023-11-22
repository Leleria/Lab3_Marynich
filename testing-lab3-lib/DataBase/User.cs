using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_lab3.DataBase
{
    public class User
    {
        public int id { get; set; }
        public string login, password, repeatPassword, result, messageError;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string RepeatPassword
        {
            get { return repeatPassword; }
            set { repeatPassword = value; }
        }
        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        public string MessageError
        {
            get { return messageError; }
            set { messageError = value; }
        }

        public User() { }

        public User(string login, string password, string repeatPassword, string result, string messageError)
        {
            this.login = login;
            this.password = password;
            this.repeatPassword = repeatPassword;
            this.result = result;
            this.messageError = messageError;
        }
    }
}
