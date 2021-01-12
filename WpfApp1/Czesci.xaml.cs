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
    /// Logika interakcji dla klasy Czesci.xaml
    /// </summary>
    public partial class Czesci : Window
    {

        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }

        private List<Part> Parts = null;
        private Part part = null;
        public Czesci()
        {
            InitializeComponent();
            InitBinding();
        }


        private void InitBinding()
        {
            Parts = new List<Part>
                {
                    new Part("Karta Graficzna GeForce RTX 2080",4),
                    new Part("Procesor Intel Core i5 4690",12),
                    new Part("Pamięć RAM HyperX 16GB 3000MHz HyperX Predator CL15",16),
                    new Part("Dysk HDD Seagate Barracuda 1 TB 3.5",4)
                };

            lstPart.ItemsSource = Parts;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            part = new Part();
            DodajCzesc Okno = new DodajCzesc(part);
            Okno.ShowDialog();
           
            if (Okno.m_oPart.PartName != "" && Okno.m_oPart.Amount != 0)
            {
                Parts.Add(Okno.m_oPart);
                lstPart.ItemsSource = Parts;
                lstPart.Items.Refresh();
            }
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Wybor wybor = new Wybor();
            wybor.Show();
            this.Close();
        }
    }
}
