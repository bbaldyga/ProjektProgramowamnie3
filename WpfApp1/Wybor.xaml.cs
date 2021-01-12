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
    /// Logika interakcji dla klasy Wybor.xaml
    /// </summary>
    public partial class Wybor : Window
    {
        private List<Manager> managers = new List<Manager>();
        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }
        public Wybor()
        {
            InitializeComponent();
            managers = SystemCafe.Instance.GetManagers();
            Usertxt.Text ="Zalogowano jako " + managers[0].Login;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }
        private void Storage_Click(object sender, RoutedEventArgs e)
        {
            MagazynManager window = new MagazynManager();
            window.Show();
            this.Close();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
