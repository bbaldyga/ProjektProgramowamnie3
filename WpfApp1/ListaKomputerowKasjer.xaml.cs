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
    /// Logika interakcji dla klasy ListaKomputerowKasjer.xaml
    /// </summary>
    public partial class ListaKomputerowKasjer : Window
    {

        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }

        private List<Computer> Computers = null;
        public ListaKomputerowKasjer()
        {
            InitializeComponent();
            InitBinding();
        }
        
        private void InitBinding()
        {
            Computers = new List<Computer>
                {
                    new Computer(true, false),
                    new Computer(false, true),
                    new Computer(false, false),
                    new Computer(true,true)
                };
            lstComputer.ItemsSource = Computers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WyborKasjer wyborKasjer = new WyborKasjer();
            wyborKasjer.Show();
            this.Close();
        }
    }
}
