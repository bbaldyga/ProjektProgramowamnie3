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
    /// Logika interakcji dla klasy Lista_Zamowienia.xaml
    /// </summary>
    public partial class Lista_Zamowienia : Window
    {

        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }

        private List<Product> products = null;
        public Lista_Zamowienia()
        {
            products = SystemCafe.CashierInstance.CreateProductList();
            InitializeComponent();
        }

        private void InitBinding()
        {
            lstProduct.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products = SystemCafe.CashierInstance.GetListOfOrderedProducts();
            lstProduct.ItemsSource = products;
            lstProduct.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            this.Close();
            
        }
    }
}
