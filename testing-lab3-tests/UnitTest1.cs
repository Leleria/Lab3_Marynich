using NUnit.Framework;
using testing_lab3;

namespace testing_lab3_tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            var mainwindow = new MainWindow();
            var expect = "True";
            var actual = new Registration().CheckRegistration("+76547867567", "Пароль1$", "Пароль1$");
            Assert.AreEqual(expect, actual.Item1);
        }
    }
}