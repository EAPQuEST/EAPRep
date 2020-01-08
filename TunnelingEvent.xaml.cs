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

namespace RoutedEventsDemo
{
    /// <summary>
    /// Interaction logic for TunnelingEvent.xaml
    /// </summary>
    public partial class TunnelingEvent : Window
    {
        public TunnelingEvent()
        {
            InitializeComponent();
        }
        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs
e)
        {
            MessageBox.Show("Stack Pannel");
        }
        private void txt3_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("txt3");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "i am changed by button click";
        }
    }
}
    

