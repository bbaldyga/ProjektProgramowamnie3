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
    /// Logika interakcji dla klasy MagazynManager.xaml
    /// </summary>
    public partial class MagazynManager : Window
    {

        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }
        public MagazynManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UrzadzeniaPreyferyjne window = new UrzadzeniaPreyferyjne();
            window.Show();
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Czesci window = new Czesci();
            window.Show();
            this.Close();

        }

      

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Wybor wybor = new Wybor();
            wybor.Show();
            this.Close();
        }
    }
}
