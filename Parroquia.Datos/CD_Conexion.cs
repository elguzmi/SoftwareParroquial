using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Parroquia.Datos
{
    public class CD_Conexion
    {

        //Server=GAMINGUZMI\\SERVERSANTI;Database=Parroquia;Integrated Security=true //DESKTOP-6BM9I17\SQLEXPRESS
        string cadena = "Server=GAMINGUZMI\\SERVERSANTI;Database=Parroquia;Integrated Security=true";
        public SqlConnection Conexion = new SqlConnection();

        public CD_Conexion()
        {
            Conexion.ConnectionString = cadena;
        }

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
