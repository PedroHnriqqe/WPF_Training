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

namespace CompleteLoginApp_Project
{
    /// <summary>
    /// Interaction logic for AppLogin.xaml
    /// </summary>
    public partial class AppLogin : UserControl
    {
        public AppLogin()
        {
            InitializeComponent();
        
           
        }

        public void Login_Btn(object sender, RoutedEventArgs e)
        {
            string passwordEntered = LoginPassword.Password;

            string? environmentPw = Environment.GetEnvironmentVariable("InvoiceManagement");

            if(environmentPw != null)
            {
                if(passwordEntered == environmentPw)
                {
                    MessageBox.Show("Entered corred password!");
                    Window window = Window.GetWindow(this);
                    window.Content = new StoreUI();
                } else
                {
                    MessageBox.Show("Entered wrong password!");
                }
            }
            else
            {
                MessageBox.Show("Environment variable not found");
            }
        }
    }
}
