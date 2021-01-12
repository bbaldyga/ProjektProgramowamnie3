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
    /// Logika interakcji dla klasy SzczegolyComputer.xaml
    /// </summary>
    public partial class SzczegolyComputer : Window
    {

        private void rectangle2_MouseDown(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }
        private Computer m_oComputer = null;
        public SzczegolyComputer(Computer computer)
        {
            InitializeComponent();
            m_oComputer = computer;
            InitBinding();
        }

        private void InitBinding()
        {
            plnComputerForm.DataContext = m_oComputer;

            if (m_oComputer.Use == true)
                Use.Text = "tak";
            else
                Use.Text = "nie";

            if (m_oComputer.Work == true)
                Work.Text = "tak";
            else
                Work.Text = "nie";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }
    }
}

