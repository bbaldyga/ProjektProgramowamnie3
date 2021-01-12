using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for DodajCzesc.xaml
    /// </summary>
    public partial class DodajCzesc : Window
    {


        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }

        public Part m_oPart = null;
        public DodajCzesc(Part part)
        {
            InitializeComponent();
            m_oPart = part;
            this.DataContext = m_oPart;
        }
        public void InitBinding()
        {
            plnPartForm.DataContext = m_oPart;
        }
       

        private void Ammount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            this.Close();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Ammount.Text != "")
            {
                m_oPart.Amount = Convert.ToInt32(Ammount.Text);
            }
            this.Close();
        }
    }
}
