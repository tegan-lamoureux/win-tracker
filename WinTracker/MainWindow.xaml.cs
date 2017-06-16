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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool tracking = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_Click(object sender, RoutedEventArgs e)
        {
            if (! tracking)
            {
                tracking = true;

                tb_stop_id.IsEnabled = false;
                bttn_track.Content = "Reset";
            }
            else
            {
                tracking = false;

                tb_stop_id.IsEnabled = true;
                bttn_track.Content = "Track";

                tb_arrival_1.Text = "No Arrival Data";
                tb_arrival_2.Text = "No Arrival Data";
            }

        }
    }
}
