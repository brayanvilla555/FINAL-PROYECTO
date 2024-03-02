using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_PROYECTO.Config
{
    internal class Conexion
    {
        public SqlConnection conectar()
        {
            SqlConnection sqlConnection = null;
            string cadenaConexion = "Data Source=161.132.40.29;Initial Catalog=ZURICH_CORP;Persist Security Info=True;User ID=estudiante;Password=Unc.2024";
            try
            {
                sqlConnection = new SqlConnection(cadenaConexion);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error en la conexion: ", ex.Message);
            }
            return sqlConnection;
        }
    }
}
