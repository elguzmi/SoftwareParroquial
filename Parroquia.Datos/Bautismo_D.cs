using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parroquia.Entidades;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Parroquia.Datos
{
    public class Bautismo_D
    {


        CD_Conexion conexion = new CD_Conexion();


        public void InsertarBautismo(String nombreSP, List<Bautismo_E> lst)  // como parametro necesita el nombre del procedimiento almacenado y una lista generica que va a conetener parametros un array
        {
            SqlCommand cmd;           // nos sirve para insert, delete y update
            try
            {
                conexion.AbrirConexion();
                cmd = new SqlCommand(nombreSP, conexion.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)   // para recorrer desde 0 hasta n el mayor numero de la lista
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)   // esta validacion es para todos los parametros de entrada
                        {
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        if (lst[i].Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                    cmd.ExecuteNonQuery();

                    // recuperar parametros de salida
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            conexion.CerrarConexion();
        }


        public DataTable listado(String NombreSP, List<Bautismo_E> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;       // va a hacer como nuestro cmd permite ejecutar nuestro procedimientos y va a llenar la informaion a nuestro data table

            try
            {
                da = new SqlDataAdapter(NombreSP, conexion.Conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);    // se ejecuta solo
                    }

                }
                da.Fill(dt);    // nuestro data adapter mete la informacion que va a recuperar de la base da datos
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;

        }




    }
}
