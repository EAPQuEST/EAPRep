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
    /// Interaction logic for BubblingEvent.xaml
    /// </summary>
    public partial class BubblingEvent : Window
    {
        public BubblingEvent()
        {
            InitializeComponent();
        }
        private void btnOuter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am rised by outer button");
        }
        private void btnInner_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am rised by inner button");
        }
        private void StackPanel_PreviewMouseMove(object sender, MouseEventArgs e)
        {

        }
        private void btnInner_PreviewMouseMove(object sender, MouseEventArgs e)
        {

        }
        private void btnOuter_PreviewMouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
