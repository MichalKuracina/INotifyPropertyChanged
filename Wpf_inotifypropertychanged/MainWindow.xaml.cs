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
using Wpf_inotifypropertychanged.Model;

namespace Wpf_inotifypropertychanged
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CountModel countModel = new CountModel();
        public MainWindow()
        {
            InitializeComponent();
            counterLabel.DataContext = countModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            countModel.Counter++;
        }
    }
}
