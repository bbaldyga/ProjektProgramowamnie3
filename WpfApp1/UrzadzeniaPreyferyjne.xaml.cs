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
    /// Logika interakcji dla klasy UrzadzeniaPreyferyjne.xaml
    /// </summary>
    public partial class UrzadzeniaPreyferyjne : Window
    {

        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }

        private List<PeripheralDevice> peripheralDevices = null;
        public UrzadzeniaPreyferyjne()
        {
            InitializeComponent();
            InitBinding();
        }


        private void InitBinding()
        {
            peripheralDevices = new List<PeripheralDevice>

                {
                    new PeripheralDevice("Klawiatura SteelSeries Apex 100",12),
                    new PeripheralDevice("Słuchawki Razer Kraken",4),
                    new PeripheralDevice("Myszka SteelSeries Rival 110",23),
                    new PeripheralDevice("Monitor Acer Nitro VG240YBMIIX ",7),
                    new PeripheralDevice("Myszka Razer Deathadder elite ",14),
                    new PeripheralDevice("Słuchawki Steelseries Arctis 5 ",10),
                    new PeripheralDevice("Drukarka HP Neverstop 1000w  ",2),
                    new PeripheralDevice("Monitor HP 25Mx ",5),
                };

            lstPeripheral.ItemsSource = peripheralDevices;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PeripheralDevice newPeripherial = new PeripheralDevice();
            DodajUrzadzenie Okno = new DodajUrzadzenie(newPeripherial);
            Okno.ShowDialog();

            if (Okno.m_oDevice.PeripheralDeviceName != "" && Okno.m_oDevice.Amount != 0)
            {
                peripheralDevices.Add(Okno.m_oDevice);
                lstPeripheral.ItemsSource = peripheralDevices;
                lstPeripheral.Items.Refresh();
            }
        }

        private void lstPeripheral_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MagazynManager window = new MagazynManager();
            window.Show();
            this.Close();
        }
    }
}
    