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

namespace Macronomics
{
    public partial class LoginPage : Page
    {
        private readonly Window _window;

        public LoginPage(Window mainWindow)
        {
            _window = mainWindow;
            InitializeComponent();
        }

        private void LoginBtnClicked(object sender, RoutedEventArgs e)
        {
            string username = UsernameTxt.Text;
            string password = PasswordTxt.Password;
            if (!String.IsNullOrEmpty(UsernameTxt.Text) && !String.IsNullOrEmpty(PasswordTxt.Password))
            {
                Login(username, password);
            }
        }

        private void Login(string username, string password){

            _window.Content = new WeightPage(_window);
        }
    }
}
