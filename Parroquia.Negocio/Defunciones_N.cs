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
    public class Defunciones_N
    {
        public String No_Defuncion { get; set;}
        public String Libro { get; set; }
        public String Folio { get; set; }
        public String Numero { get; set; }
        public String Nombre { get; set; }
        public String Fecha_Sepelio { get; set; }
        public String Ciudad_Origen { get; set; }
        public String Edad{ get; set; }

        public String Padres { get; set; }
        public String Estado_Civil { get; set; }
        public String Ocacion_Muerte{ get; set; }
        public String Doy_Fe{ get; set; }
        public String NotaMarginal { get; set; }
        public int Firmante { get; set; }
        public int IdFirmante { get; set; }



        Defunciones_D bauD = new Defunciones_D();

        public DataTable ListadoMinistros()
        {
            return bauD.listado("ListarMinistros", null);
        }

        public DataTable ListarDefunciones()
        {
            return bauD.listado("ListarDefunciones", null);
        }

        public DataTable TraerDefuncion()
        {
            List<Defunciones_E> lst = new List<Defunciones_E>();

            try
            {
                lst.Add(new Defunciones_E("@Dato", 1));
                lst.Add(new Defunciones_E("@No_Defuncion", No_Defuncion));
                lst.Add(new Defunciones_E("@Nombre", ""));
                lst.Add(new Defunciones_E("@NombrePadres", ""));
                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaDefunciones", lst);
        }


        //Insertar bautismo
        public String InsertarDefuncion()
        {
            String msj = "";
            List<Defunciones_E> lst = new List<Defunciones_E>();
            try
            {
                lst.Add(new Defunciones_E("@Dato", 1));
                lst.Add(new Defunciones_E("@No_Defuncion", No_Defuncion));
                lst.Add(new Defunciones_E("@Libro", Libro));
                lst.Add(new Defunciones_E("@Folio", Folio));
                lst.Add(new Defunciones_E("@Numero", Numero));
                lst.Add(new Defunciones_E("@Nombre", Nombre));
                lst.Add(new Defunciones_E("@FechaSepelio", Fecha_Sepelio));
                lst.Add(new Defunciones_E("@CiudadOrigen", Ciudad_Origen));
                lst.Add(new Defunciones_E("@Edad", Edad));
                
                lst.Add(new Defunciones_E("@Padres", Padres));
                lst.Add(new Defunciones_E("@EstadoCivil", Estado_Civil));
                lst.Add(new Defunciones_E("@OcacionMuerte", Ocacion_Muerte));     
                lst.Add(new Defunciones_E("@DoyFe", Doy_Fe));
                lst.Add(new Defunciones_E("@NotaMarginal", NotaMarginal));
                lst.Add(new Defunciones_E("@Firmante", Firmante));
              
                // pasar parametros de salida 

                lst.Add(new Defunciones_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarDefuncion("PDefunciones", lst);
                msj = lst[15].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }

        public String EditarDefuncion()
        {
            String msj = "";
            List<Defunciones_E> lst = new List<Defunciones_E>();
            try
            {
                lst.Add(new Defunciones_E("@Dato", 2));
                lst.Add(new Defunciones_E("@No_Defuncion", No_Defuncion));
                lst.Add(new Defunciones_E("@Libro", 0));
                lst.Add(new Defunciones_E("@Folio", 0));
                lst.Add(new Defunciones_E("@Numero", 0));
                lst.Add(new Defunciones_E("@Nombre", Nombre));
                lst.Add(new Defunciones_E("@FechaSepelio", Fecha_Sepelio));
                lst.Add(new Defunciones_E("@CiudadOrigen", Ciudad_Origen));
                lst.Add(new Defunciones_E("@Edad", Edad));

                lst.Add(new Defunciones_E("@Padres", Padres));
                lst.Add(new Defunciones_E("@EstadoCivil", Estado_Civil));
                lst.Add(new Defunciones_E("@OcacionMuerte", Ocacion_Muerte));
                lst.Add(new Defunciones_E("@DoyFe", Doy_Fe));
                lst.Add(new Defunciones_E("@NotaMarginal", NotaMarginal));
                lst.Add(new Defunciones_E("@Firmante", Firmante));

                // pasar parametros de salida 

                lst.Add(new Defunciones_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarDefuncion("PDefunciones", lst);
                msj = lst[15].Valor.ToString();

            }
            catch (Exception ex)            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }

        public String Eliminar()
        {
            String msj = "";
            List<Defunciones_E> lst = new List<Defunciones_E>();
            try
            {
                
                lst.Add(new Defunciones_E("@Dato", 3));
                lst.Add(new Defunciones_E("@No_Defuncion", No_Defuncion));
                lst.Add(new Defunciones_E("@Libro", 0));
                lst.Add(new Defunciones_E("@Folio", 0));
                lst.Add(new Defunciones_E("@Numero", 0));
                lst.Add(new Defunciones_E("@Nombre", ""));
                lst.Add(new Defunciones_E("@FechaSepelio", ""));
                lst.Add(new Defunciones_E("@CiudadOrigen", ""));
                lst.Add(new Defunciones_E("@Edad", 0));
                
                lst.Add(new Defunciones_E("@Padres", ""));
                lst.Add(new Defunciones_E("@EstadoCivil", ""));
                lst.Add(new Defunciones_E("@OcacionMuerte", ""));
                lst.Add(new Defunciones_E("@DoyFe", ""));
                lst.Add(new Defunciones_E("@NotaMarginal", ""));
                lst.Add(new Defunciones_E("@Firmante", 0));


                // pasar parametros de salida 

                lst.Add(new Defunciones_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarDefuncion("PDefunciones", lst);
                msj = lst[15].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }


        public DataTable BuscarPartida()
        {
            List<Defunciones_E> lst = new List<Defunciones_E>();

            try
            {
                lst.Add(new Defunciones_E("@Dato", 2));
                lst.Add(new Defunciones_E("@No_Defuncion", No_Defuncion));
                lst.Add(new Defunciones_E("@Nombre", ""));
                lst.Add(new Defunciones_E("@NombrePadres", ""));


            }
            catch(Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaDefunciones", lst);
        }

        public DataTable BuscarporNombre()
        {
            List<Defunciones_E> lst = new List<Defunciones_E>();

            try
            {
                lst.Add(new Defunciones_E("@Dato", 3));
                lst.Add(new Defunciones_E("@No_Defuncion", 0));
                lst.Add(new Defunciones_E("@Nombre", Nombre));
                lst.Add(new Defunciones_E("@NombrePadres", ""));


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaDefunciones", lst);
        }

        public DataTable BuscarporPadres()
        {
            List<Defunciones_E> lst = new List<Defunciones_E>();

            try
            {
                lst.Add(new Defunciones_E("@Dato", 4));
                lst.Add(new Defunciones_E("@No_Defuncion", 0));
                lst.Add(new Defunciones_E("@Nombre", ""));
                lst.Add(new Defunciones_E("@NombrePadres", Padres));


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaDefunciones", lst);
        }

        public DataTable TraerCargo()
        {
            List<Defunciones_E> lst = new List<Defunciones_E>();

            try
            {
                lst.Add(new Defunciones_E("@Dato", 1));
                lst.Add(new Defunciones_E("@Id", IdFirmante));
                
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
    