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
using System.Windows.Shapes;

namespace TemplateDemo
{
    /// <summary>
    /// Interaction logic for DataTemplate.xaml
    /// </summary>
    public partial class DataTemplate : Window
    {
        public Person obj { get; set; }
        public DataTemplate()
        {
            InitializeComponent();
            obj = new Person();
            obj.Name = "Deepu";
            obj.Age = 18;
            this.DataContext = this;
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //public override string ToString()
        //{
        // return Name;
        //}
    }

}

