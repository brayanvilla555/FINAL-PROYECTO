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

namespace FINAL_PROYECTO
{
    /// <summary>
    /// Lógica de interacción para _02_menu.xaml
    /// </summary>
    public partial class _02_menu : Window
    {
        public _02_menu()
        {
            InitializeComponent();
        }

        private void b_inicio_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Vistas.Inicio();

        }
        private void b_prestamos_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Vistas.Prestamos();

        }
        private void b_gestionar_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Windows_mouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

        }
    }
}
