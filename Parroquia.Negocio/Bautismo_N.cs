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
    public class Bautismo_N
    {
        public String PartidaCodigo { get; set;}
        public String Libro { get; set; }
        public String Folio { get; set; }
        public String Numero { get; set; }
        public String Nombre { get; set; }
        public String Ministro { get; set; }
        public String FechaBautismo { get; set; }
        public String FechaNacimiento{ get; set; }
        public String LugarNacimiento{ get; set; }
        public String Padres { get; set; }
        public String AbuelosP { get; set; }
        public String AbuelosM{ get; set; }
        public String Padrinos{ get; set; }
        public int DoyFe{ get; set; }
        public String NotaMarginal{ get; set; }
        public int Firmante { get; set; }
        public int IdFirmante { get; set; }






        Bautismo_D bauD = new Bautismo_D();

        public DataTable ListadoMinistros()
        {
            return bauD.listado("ListarMinistros", null);
        }

        public DataTable ListarBautismo()
        {
            return bauD.listado("ListarBautismos", null);
        }

        public DataTable TraerBautismo()
        {
            List<Bautismo_E> lst = new List<Bautismo_E>();

            try
            {
                lst.Add(new Bautismo_E("@Dato", 1));
                lst.Add(new Bautismo_E("@Partida", PartidaCodigo));
                lst.Add(new Bautismo_E("@Nombre", ""));
                lst.Add(new Bautismo_E("@NombrePadres", ""));
                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaBautisos", lst);
        }


        //Insertar bautismo
        public String InsertarBautismo()
        {
            String msj = "";
            List<Bautismo_E> lst = new List<Bautismo_E>();
            try
            {
                lst.Add(new Bautismo_E("@Dato", 1));
                lst.Add(new Bautismo_E("@Partida_Codigo", PartidaCodigo));
                lst.Add(new Bautismo_E("@Libro", Libro));
                lst.Add(new Bautismo_E("@Folio", Folio));
                lst.Add(new Bautismo_E("@Numero", Numero));
                lst.Add(new Bautismo_E("@Nombre", Nombre));
                lst.Add(new Bautismo_E("@Ministro", Ministro));
                lst.Add(new Bautismo_E("@FechaBautismo", FechaBautismo));
                lst.Add(new Bautismo_E("@FechaNacimiento",FechaNacimiento));
                lst.Add(new Bautismo_E("@LugarNacimiento", LugarNacimiento));
                lst.Add(new Bautismo_E("@Padres", Padres));
                lst.Add(new Bautismo_E("@AbuelosP", AbuelosP));
                lst.Add(new Bautismo_E("@AbuelosM", AbuelosM));
                lst.Add(new Bautismo_E("@Padrinos", Padrinos));
                lst.Add(new Bautismo_E("@DoyFe", DoyFe));
                lst.Add(new Bautismo_E("@NotaMarginal",NotaMarginal ));
                lst.Add(new Bautismo_E("@Firmante", Firmante));
              
                // pasar parametros de salida 

                lst.Add(new Bautismo_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarBautismo("Bautizos", lst);
                msj = lst[17].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }

        public String EditarBautismo()
        {
            String msj = "";
            List<Bautismo_E> lst = new List<Bautismo_E>();
            try
            {
                lst.Add(new Bautismo_E("@Dato", 2));
                lst.Add(new Bautismo_E("@Partida_Codigo", PartidaCodigo));
                lst.Add(new Bautismo_E("@Libro", 0));
                lst.Add(new Bautismo_E("@Folio", 0));
                lst.Add(new Bautismo_E("@Numero", 0));
                lst.Add(new Bautismo_E("@Nombre", Nombre));
                lst.Add(new Bautismo_E("@Ministro", Ministro));
                lst.Add(new Bautismo_E("@FechaBautismo", FechaBautismo));
                lst.Add(new Bautismo_E("@FechaNacimiento", FechaNacimiento));
                lst.Add(new Bautismo_E("@LugarNacimiento", LugarNacimiento));
                lst.Add(new Bautismo_E("@Padres", Padres));
                lst.Add(new Bautismo_E("@AbuelosP", AbuelosP));
                lst.Add(new Bautismo_E("@AbuelosM", AbuelosM));
                lst.Add(new Bautismo_E("@Padrinos", Padrinos));
                lst.Add(new Bautismo_E("@DoyFe", DoyFe));
                lst.Add(new Bautismo_E("@NotaMarginal", NotaMarginal));
                lst.Add(new Bautismo_E("@Firmante", Firmante));

                // pasar parametros de salida 

                lst.Add(new Bautismo_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarBautismo("Bautizos", lst);
                msj = lst[17].Valor.ToString();

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
            List<Bautismo_E> lst = new List<Bautismo_E>();
            try
            {
                lst.Add(new Bautismo_E("@Dato", 3));
                lst.Add(new Bautismo_E("@Partida_Codigo", PartidaCodigo));
                lst.Add(new Bautismo_E("@Libro", 0));
                lst.Add(new Bautismo_E("@Folio", 0));
                lst.Add(new Bautismo_E("@Numero", 0));
                lst.Add(new Bautismo_E("@Nombre", "No"));
                lst.Add(new Bautismo_E("@Ministro", "No"));
                lst.Add(new Bautismo_E("@FechaBautismo", "No"));
                lst.Add(new Bautismo_E("@FechaNacimiento", "No"));
                lst.Add(new Bautismo_E("@LugarNacimiento", "No"));
                lst.Add(new Bautismo_E("@Padres", "No"));
                lst.Add(new Bautismo_E("@AbuelosP", "No"));
                lst.Add(new Bautismo_E("@AbuelosM", "No"));
                lst.Add(new Bautismo_E("@Padrinos", "No"));
                lst.Add(new Bautismo_E("@DoyFe", 0));
                lst.Add(new Bautismo_E("@NotaMarginal", "No"));
                lst.Add(new Bautismo_E("@Firmante", 0));


                // pasar parametros de salida 

                lst.Add(new Bautismo_E("@mensaje", SqlDbType.VarChar, 100));
                bauD.InsertarBautismo("Bautizos", lst);
                msj = lst[17].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }


        public DataTable BuscarPartida()
        {
            List<Bautismo_E> lst = new List<Bautismo_E>();

            try
            {
                lst.Add(new Bautismo_E("@Dato", 2));
                lst.Add(new Bautismo_E("@Partida", PartidaCodigo));
                lst.Add(new Bautismo_E("@Nombre", ""));
                lst.Add(new Bautismo_E("@NombrePadres", ""));


            }
            catch(Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaBautisos", lst);
        }

        public DataTable BuscarporNombre()
        {
            List<Bautismo_E> lst = new List<Bautismo_E>();

            try
            {
                lst.Add(new Bautismo_E("@Dato", 3));
                lst.Add(new Bautismo_E("@Partida", 0));
                lst.Add(new Bautismo_E("@Nombre", Nombre));
                lst.Add(new Bautismo_E("@NombrePadres", ""));


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaBautisos", lst);
        }

        public DataTable BuscarporPadres()
        {
            List<Bautismo_E> lst = new List<Bautismo_E>();

            try
            {
                lst.Add(new Bautismo_E("@Dato", 4));
                lst.Add(new Bautismo_E("@Partida", 0));
                lst.Add(new Bautismo_E("@Nombre", ""));
                lst.Add(new Bautismo_E("@NombrePadres", Padres));


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaBautisos", lst);
        }

        public DataTable TraerCargo()
        {
            List<Bautismo_E> lst = new List<Bautismo_E>();

            try
            {
                lst.Add(new Bautismo_E("@Dato", 1));
                lst.Add(new Bautismo_E("@Id", IdFirmante));
                
                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("BusquedaFirmantes", lst);
        }

        public DataTable TraerRegistro(string Codigo_Partida)
        {
            List<Bautismo_E> lst = new List<Bautismo_E>();
            try
            {
                lst.Add(new Bautismo_E("@Codigo", Codigo_Partida));
                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bauD.listado("TraerRegistroB", lst);
        }




    }
}
    