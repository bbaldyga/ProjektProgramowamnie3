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
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Productx : Window
    {

        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }

        private List<Product> Products = null;
        public Productx()
        {
            InitializeComponent();
            InitBinding();
        }


        private void InitBinding()
        {
            Products = new List<Product>
                {
                    new Product("Pizza margarita",5),
                    new Product("Coca-Cola 0.5L",43),
                    new Product("Czekolada mleczna Milka",24),
                    new Product("Shake czekoladowy",53),
                    new Product("Kawa",76),
                    new Product("Chipsy Maczugi o smaku Ketchup",30),
                    new Product("Napój Monster energy drink Mango Loco",66),
                    new Product("Pizza Arka (dynia ser i świnia)",13)
                };
            lstProduct.ItemsSource = Products;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lstProduct.ItemsSource);
            view.Filter = UseFilter;
        }   

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Lista_Zamowienia lista_Zamowienia = new Lista_Zamowienia();
            lista_Zamowienia.Show();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (lstProduct.SelectedItem != null)

            {
                Product product = lstProduct.SelectedItem as Product;
                if (product.Amount > 0)
                {
                    SystemCafe.CashierInstance.AddProduct(product.ProductName);
                    product.Amount--;
                    lstProduct.Items.Refresh();
                }
                else
                    MessageBox.Show("Brak Produktu");
            }
            else MessageBox.Show("Zaznacz pole!");
        }

        private bool UseFilter(object product)
        {
            if (String.IsNullOrEmpty(FilterTextBox.Text))
                return true;
            else
                return ((product as Product).ProductName.IndexOf(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lstProduct.ItemsSource).Refresh();
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WyborKasjer wyborKasjer = new WyborKasjer();
            wyborKasjer.Show();
            this.Close();
        }
    }
}
