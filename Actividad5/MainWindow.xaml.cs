﻿using System.Windows;
using System.Windows.Controls;

namespace Actividad5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numerosPulsados.Text += (sender as Button).Content.ToString();
        }
    }
}
