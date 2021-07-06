using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Parroquia.Datos
{
    public class ReporteConfirmacion_D
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public DataTable Datos(string Codigo)
        {
            DataTable Tabla = new DataTable();
            SqlCommand comando = new SqlCommand("ReporteConfirmacion");
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", Codigo);
            SqlDataAdapter llenar = new SqlDataAdapter();
            llenar.SelectCommand = comando;
            llenar.Fill(tabla);

            return tabla;

        }
    }
}
