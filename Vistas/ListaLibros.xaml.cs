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


namespace FINAL_PROYECTO.Vistas
{
    /// <summary>
    /// Lógica de interacción para ListaLibros.xaml
    /// </summary>
    public partial class ListaLibros : UserControl
    {
        public ListaLibros()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Vistas.RegistrarLibro abrir  = new Vistas.RegistrarLibro();
            Window ventanaSecundaria = new Window();
            ventanaSecundaria.ShowDialog();
        }
    }
}
