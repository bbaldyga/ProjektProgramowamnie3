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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy WyborKasjer.xaml
    /// </summary>
    public partial class WyborKasjer : Window
    {
        private List<Cashier> cashiers = new List<Cashier>();
        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }
        public WyborKasjer()
        {
            InitializeComponent();
            cashiers = SystemCafe.Instance.GetCashiers();
            Usertxt.Text = "Zalogowano jako " + cashiers[0].Login;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListaKomputerowKasjer window = new ListaKomputerowKasjer();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Productx productx = new Productx();
            productx.Show();
            this.Close();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
