using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HELICORSA.Conn
{
    class Conexion
    {
        SqlConnection Conn = new SqlConnection();
        static string Servidor;
        static string BD;
        static string Usuario;
        static string Contraseña;
        static string puerto;
        string cadenaConexion = "Data Sourcer" + Servidor + "," + puerto + ";" + "user id=" + Usuario + ";" + "password=" + Contraseña + ";"+"Initial Catalog"+BD+"";
    }
}
