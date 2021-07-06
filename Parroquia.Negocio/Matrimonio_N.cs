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
    public class Matrimonio_N
    {
        public String PartidaCodigo { get; set; }
        public String Libro { get; set; }
        public String Folio { get; set; }
        public String Numero { get; set; }
        public String FechaMatrimonio { get; set; }
        public String Presencio  { get; set; }

        //datos del novio
        public String Nombre_Novio { get; set; }
        public String Padres_Novio { get; set; }
        public String Parroquia_Novio { get; set; }
        public String Fecha_Bautismo_Novio { get; set; }
        public String LibroNovio { get; set; }
        public String Folio_Novio { get; set; }
        public String Acta_Novio { get; set; }

        //datos de la novia
        public String Nombre_Novia { get; set; }
        public String Padres_Novia { get; set; }
        public String Parroquia_Novia { get; set; }
        public String Fecha_Bautismo_Novia { get; set; }
        public String LibroNovia { get; set; }
        public String Folio_Novia { get; set; }
        public String Acta_Novia { get; set; }

        public String Testigos { get; set; }
        public int DoyFe { get; set; }
        public String NotaMarginal { get; set; }
        public int Firmante { get; set; }


        Matrimonio_D MatriD = new Matrimonio_D();

        public DataTable ListadoMinistros()
        {
       
            return MatriD.listado("ListarMinistros", null);
        }

        public DataTable ListadoDoyFe()
        {

            return MatriD.listado("ListarDoyFe", null);
        }
        public DataTable ListarMatrimonios()
        {
            return MatriD.listado("ListarMatrimonios", null);
        }

        public DataTable TraerCargo()
        {
            List<Matrimonio_E> lst = new List<Matrimonio_E>();

            try
            {
                lst.Add(new Matrimonio_E("@Dato", 1));
                lst.Add(new Matrimonio_E("@Id", Firmante));

                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return MatriD.listado("BusquedaFirmantes", lst);
        }
        public DataTable TraerMatrimonio()
        {
            List<Matrimonio_E> lst = new List<Matrimonio_E>();

            try
            {
                lst.Add(new Matrimonio_E("@Dato", 1));
                lst.Add(new Matrimonio_E("@Codigo_Partida", PartidaCodigo));
                lst.Add(new Matrimonio_E("@Nombre_Novio", "")); 
                lst.Add(new Matrimonio_E("@Nombre_Novia", ""));


                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return MatriD.listado("BusquedaMatrimonios", lst);
        }

        public DataTable BuscarPorCodigo()
        {
            List<Matrimonio_E> lst = new List<Matrimonio_E>();

            try
            {
                lst.Add(new Matrimonio_E("@Dato", 2));
                lst.Add(new Matrimonio_E("@Codigo_Partida", PartidaCodigo));
                lst.Add(new Matrimonio_E("@Nombre_Novio", ""));
                lst.Add(new Matrimonio_E("@Nombre_Novia", ""));


                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return MatriD.listado("BusquedaMatrimonios", lst);
        }

        public DataTable BuscarPorNovio()
        {
            List<Matrimonio_E> lst = new List<Matrimonio_E>();

            try
            {
                lst.Add(new Matrimonio_E("@Dato", 3));
                lst.Add(new Matrimonio_E("@Codigo_Partida", 0));
                lst.Add(new Matrimonio_E("@Nombre_Novio", Nombre_Novio));
                lst.Add(new Matrimonio_E("@Nombre_Novia", ""));


                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return MatriD.listado("BusquedaMatrimonios", lst);
        }

        public DataTable BuscarPorNovia()
        {
            List<Matrimonio_E> lst = new List<Matrimonio_E>();

            try
            {
                lst.Add(new Matrimonio_E("@Dato", 4));
                lst.Add(new Matrimonio_E("@Codigo_Partida", 0));
                lst.Add(new Matrimonio_E("@Nombre_Novio", ""));
                lst.Add(new Matrimonio_E("@Nombre_Novia", Nombre_Novia));


                // pasar parametros de salida 
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return MatriD.listado("BusquedaMatrimonios", lst);
        }




        //Insertar Matrimonio
        public String InsertarMatrimonio()
        {
            String msj = "";
            List<Matrimonio_E> lst = new List<Matrimonio_E>();
            try
            {
                lst.Add(new Matrimonio_E("@Dato", 1));
                lst.Add(new Matrimonio_E("@Partida_Codigo", PartidaCodigo));
                lst.Add(new Matrimonio_E("@Libro", Libro));
                lst.Add(new Matrimonio_E("@Folio", Folio));
                lst.Add(new Matrimonio_E("@Numero", Numero));

                //Datos generales
                lst.Add(new Matrimonio_E("@Fecha_Matrimonio", FechaMatrimonio));
                lst.Add(new Matrimonio_E("@Presencio", Presencio));

                //Datos Novio
                lst.Add(new Matrimonio_E("@Nombre_Novio", Nombre_Novio));
                lst.Add(new Matrimonio_E("@Padres_Novio", Padres_Novio));
                lst.Add(new Matrimonio_E("@Parroquia_Novio", Parroquia_Novio));
                lst.Add(new Matrimonio_E("@Fecha_Bautismo_Novio", Fecha_Bautismo_Novio));
                lst.Add(new Matrimonio_E("@Libro_H", LibroNovio));
                lst.Add(new Matrimonio_E("@Folio_H", Folio_Novio));
                lst.Add(new Matrimonio_E("@Acta_H", Acta_Novio));
                //Datos Novia
                lst.Add(new Matrimonio_E("@Nombre_Novia", Nombre_Novia));
                lst.Add(new Matrimonio_E("@Padres_Novia", Padres_Novia));
                lst.Add(new Matrimonio_E("@Parroquia_Novia", Parroquia_Novia));
                lst.Add(new Matrimonio_E("@Fecha_Bautismo_Novia", Fecha_Bautismo_Novia));
                lst.Add(new Matrimonio_E("@Libro_M", LibroNovia));
                lst.Add(new Matrimonio_E("@Folio_M", Folio_Novia));
                lst.Add(new Matrimonio_E("@Acta_M", Acta_Novia));

                //datos finales
                lst.Add(new Matrimonio_E("@Testigos", Testigos));
                lst.Add(new Matrimonio_E("@DoyFe", DoyFe));
                lst.Add(new Matrimonio_E("@NotaMarginal", NotaMarginal));
                lst.Add(new Matrimonio_E("@Firmante", Firmante));

                // pasar parametros de salida 

                lst.Add(new Matrimonio_E("@mensaje", SqlDbType.VarChar, 100));
                MatriD.InsertarMatrimonio("PMatrimonios", lst);
                msj = lst[25].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }


        public String EditarMatrimonio()
        {
            String msj = "";
            List<Matrimonio_E> lst = new List<Matrimonio_E>();
            try
            {
                lst.Add(new Matrimonio_E("@Dato", 2));
                lst.Add(new Matrimonio_E("@Partida_Codigo", PartidaCodigo));
                lst.Add(new Matrimonio_E("@Libro", 0));
                lst.Add(new Matrimonio_E("@Folio", 0));
                lst.Add(new Matrimonio_E("@Numero", 0));

                //Datos generales
                lst.Add(new Matrimonio_E("@Fecha_Matrimonio", FechaMatrimonio));
                lst.Add(new Matrimonio_E("@Presencio", Presencio));

                //Datos Novio
                lst.Add(new Matrimonio_E("@Nombre_Novio", Nombre_Novio));
                lst.Add(new Matrimonio_E("@Padres_Novio", Padres_Novio));
                lst.Add(new Matrimonio_E("@Parroquia_Novio", Parroquia_Novio));
                lst.Add(new Matrimonio_E("@Fecha_Bautismo_Novio", Fecha_Bautismo_Novio));
                lst.Add(new Matrimonio_E("@Libro_H", LibroNovio));
                lst.Add(new Matrimonio_E("@Folio_H", Folio_Novio));
                lst.Add(new Matrimonio_E("@Acta_H", Acta_Novio));
                //Datos Novia
                lst.Add(new Matrimonio_E("@Nombre_Novia", Nombre_Novia));
                lst.Add(new Matrimonio_E("@Padres_Novia", Padres_Novia));
                lst.Add(new Matrimonio_E("@Parroquia_Novia", Parroquia_Novia));
                lst.Add(new Matrimonio_E("@Fecha_Bautismo_Novia", Fecha_Bautismo_Novia));
                lst.Add(new Matrimonio_E("@Libro_M", LibroNovia));
                lst.Add(new Matrimonio_E("@Folio_M", Folio_Novia));
                lst.Add(new Matrimonio_E("@Acta_M", Acta_Novia));

                //datos finales
                lst.Add(new Matrimonio_E("@Testigos", Testigos));
                lst.Add(new Matrimonio_E("@DoyFe", DoyFe));
                lst.Add(new Matrimonio_E("@NotaMarginal", NotaMarginal));
                lst.Add(new Matrimonio_E("@Firmante", Firmante));

                // pasar parametros de salida 

                lst.Add(new Matrimonio_E("@mensaje", SqlDbType.VarChar, 100));
                MatriD.InsertarMatrimonio("PMatrimonios", lst);
                msj = lst[25].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }


        //Eliminar Matrimonio
        public String EliminarMatrimonio()
        {
            String msj = "";
            List<Matrimonio_E> lst = new List<Matrimonio_E>();
            try
            {
                lst.Add(new Matrimonio_E("@Dato", 3));
                lst.Add(new Matrimonio_E("@Partida_Codigo", PartidaCodigo));
                lst.Add(new Matrimonio_E("@Libro", 0));
                lst.Add(new Matrimonio_E("@Folio", 0));
                lst.Add(new Matrimonio_E("@Numero", 0));

                //Datos generales
                lst.Add(new Matrimonio_E("@Fecha_Matrimonio", '0'));
                lst.Add(new Matrimonio_E("@Presencio", '0'));

                //Datos Novio
                lst.Add(new Matrimonio_E("@Nombre_Novio", '0'));
                lst.Add(new Matrimonio_E("@Padres_Novio", '0'));
                lst.Add(new Matrimonio_E("@Parroquia_Novio", '0'));
                lst.Add(new Matrimonio_E("@Fecha_Bautismo_Novio", '0'));
                lst.Add(new Matrimonio_E("@Libro_H", '0'));
                lst.Add(new Matrimonio_E("@Folio_H", 0));
                lst.Add(new Matrimonio_E("@Acta_H", 0));
                //Datos Novia
                lst.Add(new Matrimonio_E("@Nombre_Novia", '0'));
                lst.Add(new Matrimonio_E("@Padres_Novia", '0'));
                lst.Add(new Matrimonio_E("@Parroquia_Novia", '0'));
                lst.Add(new Matrimonio_E("@Fecha_Bautismo_Novia", '0'));
                lst.Add(new Matrimonio_E("@Libro_M", '0'));
                lst.Add(new Matrimonio_E("@Folio_M", 0));
                lst.Add(new Matrimonio_E("@Acta_M", 0));

                //datos finales
                lst.Add(new Matrimonio_E("@Testigos", '0'));
                lst.Add(new Matrimonio_E("@DoyFe", 0));
                lst.Add(new Matrimonio_E("@NotaMarginal", "nada"));
                lst.Add(new Matrimonio_E("@Firmante", 0));

                // pasar parametros de salida 

                lst.Add(new Matrimonio_E("@mensaje", SqlDbType.VarChar, 100));
                MatriD.InsertarMatrimonio("PMatrimonios", lst);
                msj = lst[25].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return msj;   // aqui nos devuelve el procedimiento almacenado de la base de datos
        }


    }
}
