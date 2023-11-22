using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testing_lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public interface IUserInterface
    {
        string[] GetRegistrationData();
    }
    public partial class MainWindow : Window, IUserInterface
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextLoginMouseDown(object sender, MouseButtonEventArgs e)
        {
            txtLogin.Focus();
        }
        private void TxtLoginTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) && txtLogin.Text.Length > 0)
                textLogin.Visibility = Visibility.Collapsed;
            else
                textLogin.Visibility = Visibility.Visible;
        }



        private void TextPasswordMouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void TxtPasswordTextChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
                textPassword.Visibility = Visibility.Collapsed;
            else
                textPassword.Visibility = Visibility.Visible;
        }


        private void TextRepeatPasswordMouseDown(object sender, MouseButtonEventArgs e)
        {
            txtRepeatPassword.Focus();
        }

        private void TxtRepeatPasswordTextChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRepeatPassword.Password) && txtRepeatPassword.Password.Length > 0)
                textRepeatPassword.Visibility = Visibility.Collapsed;
            else
                textRepeatPassword.Visibility = Visibility.Visible;
        }


        private void BtnInput_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller(this);
            (string, string, string, string, string) result = controller.Check();
            MessageBox.Show(result.Item4);
        }

        public string[] GetRegistrationData()
        {
            string[] data = new string[3];
            data[0] = txtLogin.Text;
            data[1] = txtPassword.Password;
            data[2] = txtRepeatPassword.Password;
            return data;
        }
    }
}
