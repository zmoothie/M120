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

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für details.xaml
    /// </summary>
    public partial class details : Window
    {
        public details()
        {
            InitializeComponent();
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            details details = new details();
            details.Owner = this;
            details.Owner.Hide();
            details.ShowDialog();
        }

        
    }
}
