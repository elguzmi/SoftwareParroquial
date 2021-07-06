using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parroquia.Entidades;
using Parroquia.Datos;
using System.Data;

namespace Parroquia.Negocio
{
    public class Firmantes_N
    {
        public int No_Firmante { get; set;}
        public string Nombre { get; set; }
        public string Cargo { get; set; }




        Firmantes_D bauD = new Firmantes_D();

        
        public DataTable ListarMinistros()
        {
            return bauD.listado("ListarMinistros", null);
        }

        public DataTable TraerFimante()
        {
            List<Firmantes_E> lst = new List<Firmantes_E>();

            try
            {
                lst.Add(new Firmantes_E("@Dato", 3));
                lst.Add(new Firmantes_E("@Id", No_Firmante));
                lst.Add(new Firmantes_E("@Nombre", ""));
                lst.Add(new Firmantes_E("@Cargo", ""));
                lst.Add(new Firmantes_E("@mensaje", ""));
                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("PMinistros", lst);
        }


        //Insertar bautismo
        public String InsertarFirmante()
        {
            String msj = "";
            List<Firmantes_E> lst = new List<Firmantes_E>();
            try
            {
                lst.Add(new Firmantes_E("@Dato", 1));
                lst.Add(new Firmantes_E("@Id", 0));
                lst.Add(new Firmantes_E("@Nombre", Nombre));
                lst.Add(new Firmantes_E("@Cargo", Cargo));


                // pasar parametros de salida 

                lst.Add(new Firmantes_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarDefuncion("PMinistros", lst);
                msj = lst[4].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }

        public String EditarFirmante()
        {
            String msj = "";
            List<Firmantes_E> lst = new List<Firmantes_E>();
            try
            {
                lst.Add(new Firmantes_E("@Dato", 2));
                lst.Add(new Firmantes_E("@Id", No_Firmante));
                lst.Add(new Firmantes_E("@Nombre", Nombre));
                lst.Add(new Firmantes_E("@Cargo", Cargo));

                // pasar parametros de salida 

                lst.Add(new Firmantes_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarDefuncion("PMinistros", lst);
                msj = lst[4].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }





    }
}
    