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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (SystemCafe.CashierInstance.Login(LoginTxt.Text, PasswordTxt.Password) == true)
            {
                SystemCafe.Instance.AddLoggedCashier(LoginTxt.Text, PasswordTxt.Password);
                WyborKasjer wyborKasjer = new WyborKasjer();
                wyborKasjer.Show();
                this.Close();
            }
            else if (SystemCafe.SystemInstance.Login(LoginTxt.Text, PasswordTxt.Password) == true)
            {
                SystemCafe.Instance.AddLoggedManager(LoginTxt.Text, PasswordTxt.Password);
                Wybor window = new Wybor();
                window.Show();
                this.Close();
            }
            else
                MessageBox.Show("Błędne dane");
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
