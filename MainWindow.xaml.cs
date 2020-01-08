﻿using System;
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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Happy New Year 2020");
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is:{this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.CheckboxWeld.IsChecked = this.CheckboxAssembly.IsChecked = this.CheckboxDrill.IsChecked = this.CheckboxFold.IsChecked = this.CheckboxFold.IsChecked = this.CheckboxLaser.IsChecked =
                this.CheckboxLathe.IsChecked = this.CheckboxPlasma.IsChecked = this.CheckboxPurchase.IsChecked = this.CheckboxRoll.IsChecked = this.CheckboxSaw.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthTextBox.Text += ((CheckBox)sender).Content;
        }

        private void FinishDropdown_Selected(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteTextBox == null)
                return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.NoteTextBox.Text = (string)value.Content;
        }
    }
}
