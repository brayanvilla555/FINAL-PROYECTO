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

namespace FINAL_PROYECTO
{
    /// <summary>
    /// Lógica de interacción para _01_login.xaml
    /// </summary>
    public partial class _01_login : Window
    {
        public _01_login()
        {
            InitializeComponent();
        }
        private int loginAttempts = 0;
        private bool YourAuthenticationLogic(string username, string password)
        {
            // Aquí podrías realizar la autenticación utilizando una lógica más compleja, como consultar una base de datos,
            // verificar contra un servicio de autenticación, etc. En este ejemplo, simplemente comparamos con credenciales predefinidas.

            // Verificar si el nombre de usuario y la contraseña son correctos
            if (username == "a" && password == "a")
            {
                return true; // Las credenciales son válidas
            }
            else
            {
                return false; // Las credenciales son inválidas
            }
        }

        private void b_iniciar_Click(object sender, RoutedEventArgs e)
        {
            string username = tb_correo.Text;
            string password = passw_contrasena.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, introduzca nombre de usuario y contraseña.", "Error de inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Suponiendo que aquí tienes una lógica para verificar las credenciales en una base de datos o donde sea que las almacenes.
            bool credentialsValid = YourAuthenticationLogic(username, password);

            if (credentialsValid)
            {
                // Si las credenciales son válidas, abrir otra pantalla
                _02_menu menu = new _02_menu();
                menu.Show();
            }
            else
            {
                loginAttempts++;
                if (loginAttempts >= 3)
                {
                    MessageBox.Show("Demasiados intentos fallidos. Su cuenta ha sido bloqueada temporalmente.", "Error de inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
