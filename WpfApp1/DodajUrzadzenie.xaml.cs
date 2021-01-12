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
    /// Interaction logic for DodajUrzadzenie.xaml
    /// </summary>
    public partial class DodajUrzadzenie : Window
    {

        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }

        public PeripheralDevice m_oDevice = null;
        public DodajUrzadzenie(PeripheralDevice peripheralDevice)
        {
            InitializeComponent();
            m_oDevice = peripheralDevice;
            this.DataContext = m_oDevice;
        }
        public void InitBinding()
        {
            plnPeripheralForm.DataContext = m_oDevice;

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
                m_oDevice.Amount = Convert.ToInt32(Ammount.Text);
            }         
            this.Close();
        }
    }
}
