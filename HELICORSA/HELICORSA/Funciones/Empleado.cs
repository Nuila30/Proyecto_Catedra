using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELICORSA.Funciones
{
    class Empleado
    {
        
        public void InsertEmpleado(string Nom1,string Nom2, string Ape1, string Ape2, string Dic, string tele, string cargo, string NomC, string Gen)
        {
            Conexion Conn = new Conexion();
            String query = "INSERT INTO Empleados values ('Nom1','Nom2','Ape1','Ape2','Dic','tele','cargo','NomC','Gen')";
            
            try
            {
                using (SqlCommand command = new SqlCommand(query, Conn)) {

                }
            }
            catch
            {
            }

        }
    }
}
