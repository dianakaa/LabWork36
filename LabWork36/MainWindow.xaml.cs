﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork36
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewWindow_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new Window();
            newWindow.Title = "Новое окно";
            newWindow.ShowDialog();
        }
      
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CloseWindow closeWindow = new CloseWindow();
            if (closeWindow.ShowDialog() == false)
            {
                e.Cancel = true;
            }
        }
    }
}