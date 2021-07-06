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
    public class Confirmaciones_N
    {
        public String Codigo_Partida { get; set;}
        public String Libro { get; set; }
        public String Folio { get; set; }
        public String Numero { get; set; }
        public String Fecha_Confirmacion { get; set; }
        public String Nombre_Confirmado { get; set; }
        public String Lugar_Nacimiento { get; set; }
        public String Fecha_Nacimiento { get; set; }
        public String Padres { get; set; }
        public String Parroquia_Bautismo { get; set; }
        public String Diocesis { get; set; }
        public String Fecha_Bautismo { get; set; }
        public String LibroB { get; set; }
        public String FolioB { get; set; }
        public String NumeroB { get; set; }
        public String Padrinos{ get; set; }
        public String Ministro { get; set; }
        public String Doy_Fe { get; set; }
        public String Notas{ get; set; }
        public int Firmante { get; set; }
        

        Confirmaciones_D bauD = new Confirmaciones_D();

        public DataTable ListadoMinistros()
        {
            return bauD.listado("ListarMinistros", null);
        }

        public DataTable ListarConfirmaciones()
        {
            return bauD.listado("ListarConfirmaciones", null);
        }

        public DataTable TraerConfirmacion()
        {
            List<Confirmaciones_E> lst = new List<Confirmaciones_E>();

            try
            {
                lst.Add(new Confirmaciones_E("@Dato", 1));
                lst.Add(new Confirmaciones_E("@Codigo_Partida", Codigo_Partida));
                lst.Add(new Confirmaciones_E("@Nombre", ""));
                lst.Add(new Confirmaciones_E("@NombrePadres", ""));
                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaConfirmaciones", lst);
        }


        //Insertar bautismo
        public String InsertarConfirmacion()
        {
            String msj = "";
            List<Confirmaciones_E> lst = new List<Confirmaciones_E>();
            try
            {
                lst.Add(new Confirmaciones_E("@Dato", 1));
                lst.Add(new Confirmaciones_E("@Codigo_Partida", Codigo_Partida));
                lst.Add(new Confirmaciones_E("@Libro", Libro));
                lst.Add(new Confirmaciones_E("@Folio", Folio));
                lst.Add(new Confirmaciones_E("@Numero", Numero));
                lst.Add(new Confirmaciones_E("@FechaConfirmacion", Fecha_Confirmacion));
                lst.Add(new Confirmaciones_E("@Nombre", Nombre_Confirmado));
                lst.Add(new Confirmaciones_E("@Lugar_Nacimiento", Lugar_Nacimiento));
                lst.Add(new Confirmaciones_E("@Fecha_Nacimiento", Fecha_Nacimiento));
                lst.Add(new Confirmaciones_E("@Padres", Padres));
                lst.Add(new Confirmaciones_E("@ParroquiaB", Parroquia_Bautismo));
                lst.Add(new Confirmaciones_E("@Diocesis", Diocesis));
                lst.Add(new Confirmaciones_E("@FechaB", Fecha_Bautismo));
                lst.Add(new Confirmaciones_E("@LibroB", LibroB));
                lst.Add(new Confirmaciones_E("@FolioB", FolioB));
                lst.Add(new Confirmaciones_E("@NumeroB", NumeroB));
                
                lst.Add(new Confirmaciones_E("@Padrinos", Padrinos));
                lst.Add(new Confirmaciones_E("@Ministro", Ministro));     
                lst.Add(new Confirmaciones_E("@DoyFe", Doy_Fe));
                lst.Add(new Confirmaciones_E("@Notas", Notas));
                lst.Add(new Confirmaciones_E("@Firmante", Firmante));
              
                // pasar parametros de salida 

                lst.Add(new Confirmaciones_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarConfirmacion("PConfirmaciones", lst);
                msj = lst[21].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }

        public String EditarConfirmacion()
        {
            String msj = "";
            List<Confirmaciones_E> lst = new List<Confirmaciones_E>();
            try
            {
                lst.Add(new Confirmaciones_E("@Dato", 2));
                lst.Add(new Confirmaciones_E("@Codigo_Partida", Codigo_Partida));
                lst.Add(new Confirmaciones_E("@Libro", 0));
                lst.Add(new Confirmaciones_E("@Folio", 0));
                lst.Add(new Confirmaciones_E("@Numero", 0));
                lst.Add(new Confirmaciones_E("@FechaConfirmacion", Fecha_Confirmacion));
                lst.Add(new Confirmaciones_E("@Nombre", Nombre_Confirmado));
                lst.Add(new Confirmaciones_E("@Lugar_Nacimiento", Lugar_Nacimiento));
                lst.Add(new Confirmaciones_E("@Fecha_Nacimiento", Fecha_Nacimiento));
                lst.Add(new Confirmaciones_E("@Padres", Padres));
                lst.Add(new Confirmaciones_E("@ParroquiaB", Parroquia_Bautismo));
                lst.Add(new Confirmaciones_E("@Diocesis", Diocesis));
                lst.Add(new Confirmaciones_E("@FechaB", Fecha_Bautismo));
                lst.Add(new Confirmaciones_E("@LibroB", LibroB));
                lst.Add(new Confirmaciones_E("@FolioB", FolioB));
                lst.Add(new Confirmaciones_E("@NumeroB", NumeroB));

                lst.Add(new Confirmaciones_E("@Padrinos", Padrinos));
                lst.Add(new Confirmaciones_E("@Ministro", Ministro));
                lst.Add(new Confirmaciones_E("@DoyFe", Doy_Fe));
                lst.Add(new Confirmaciones_E("@Notas", Notas));
                lst.Add(new Confirmaciones_E("@Firmante", Firmante));

                // pasar parametros de salida 

                lst.Add(new Confirmaciones_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarConfirmacion("PConfirmaciones", lst);
                msj = lst[21].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }

        public String Eliminar()
        {
            String msj = "";
            List<Confirmaciones_E> lst = new List<Confirmaciones_E>();
            try
            {
                lst.Add(new Confirmaciones_E("@Dato", 3));
                lst.Add(new Confirmaciones_E("@Codigo_Partida", Codigo_Partida));
                lst.Add(new Confirmaciones_E("@Libro", 0));
                lst.Add(new Confirmaciones_E("@Folio", 0));
                lst.Add(new Confirmaciones_E("@Numero", 0));
                lst.Add(new Confirmaciones_E("@FechaConfirmacion", ""));
                lst.Add(new Confirmaciones_E("@Nombre", ""));
                lst.Add(new Confirmaciones_E("@Lugar_Nacimiento", ""));
                lst.Add(new Confirmaciones_E("@Fecha_Nacimiento", ""));
                lst.Add(new Confirmaciones_E("@Padres", ""));
                lst.Add(new Confirmaciones_E("@ParroquiaB", ""));
                lst.Add(new Confirmaciones_E("@Diocesis", ""));
                lst.Add(new Confirmaciones_E("@FechaB", ""));
                lst.Add(new Confirmaciones_E("@LibroB", 0));
                lst.Add(new Confirmaciones_E("@FolioB", 0));
                lst.Add(new Confirmaciones_E("@NumeroB", 0));

                lst.Add(new Confirmaciones_E("@Padrinos", ""));
                lst.Add(new Confirmaciones_E("@Ministro", ""));
                lst.Add(new Confirmaciones_E("@DoyFe", ""));
                lst.Add(new Confirmaciones_E("@Notas", ""));
                lst.Add(new Confirmaciones_E("@Firmante", 0));


                // pasar parametros de salida 

                lst.Add(new Confirmaciones_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarConfirmacion("PConfirmaciones", lst);
                msj = lst[21].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }


        public DataTable BuscarPartida()
        {
            List<Confirmaciones_E> lst = new List<Confirmaciones_E>();

            try
            {
                lst.Add(new Confirmaciones_E("@Dato", 2));
                lst.Add(new Confirmaciones_E("@Codigo_Partida", Codigo_Partida));
                lst.Add(new Confirmaciones_E("@Nombre", ""));
                lst.Add(new Confirmaciones_E("@NombrePadres", ""));


            }
            catch(Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaConfirmaciones", lst);
        }

        public DataTable BuscarporNombre()
        {
            List<Confirmaciones_E> lst = new List<Confirmaciones_E>();

            try
            {
                lst.Add(new Confirmaciones_E("@Dato", 3));
                lst.Add(new Confirmaciones_E("@Codigo_Partida", 0));
                lst.Add(new Confirmaciones_E("@Nombre", Nombre_Confirmado));
                lst.Add(new Confirmaciones_E("@NombrePadres", ""));


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaConfirmaciones", lst);
        }

        public DataTable BuscarporPadres()
        {
            List<Confirmaciones_E> lst = new List<Confirmaciones_E>();

            try
            {
                lst.Add(new Confirmaciones_E("@Dato", 4));
                lst.Add(new Confirmaciones_E("@Codigo_Partida", 0));
                lst.Add(new Confirmaciones_E("@Nombre", ""));
                lst.Add(new Confirmaciones_E("@NombrePadres", Padres));


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaConfirmaciones", lst);
        }

        public DataTable TraerCargo()
        {
            List<Confirmaciones_E> lst = new List<Confirmaciones_E>();

            try
            {
                lst.Add(new Confirmaciones_E("@Dato", 1));
                lst.Add(new Confirmaciones_E("@Id", Firmante));
                
                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaFirmantes", lst);
        }





    }
}
    