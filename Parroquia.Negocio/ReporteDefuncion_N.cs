using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parroquia.Entidades;
using Parroquia.Datos;
using System.Data;
using System.Globalization;

namespace Parroquia.Negocio
{
    public class ReporteDefuncion_N
    {
        DateTimeFormatInfo formatoFecha = new CultureInfo("es-MX", false).DateTimeFormat;
        CultureInfo ci = new CultureInfo("Es-Es");
        int mess = DateTime.Now.Month;
        public List<ReporteDefuncion_E>Listar(string Codigo)
        {
            List<ReporteDefuncion_E> Agregar = new List<ReporteDefuncion_E>();
            ReporteDefuncion_D ReporteD = new ReporteDefuncion_D();
            foreach (DataRow lista in ReporteD.Datos(Codigo).Rows)
            {
                Agregar.Add(new ReporteDefuncion_E
                {

                    No_Defuncion = lista[0].ToString(),
                    Libro = lista[1].ToString(),
                    Folio = lista[2].ToString(),
                    Numero = lista[3].ToString(),
                    Fecha_Sepelio = lista[4].ToString(),
                    Nombre_Difunto = lista[5].ToString(),
                    
                    Ciudad_Origen = lista[6].ToString(),
                    Edad = lista[7].ToString(),
          
                    Padres = lista[8].ToString(),
                    Estado_Civil = lista[9].ToString(),
                    Ocacion_Muerte = lista[10].ToString(),
                    DoyFe = lista[11].ToString(),
                    Nombre_Firmante = lista[12].ToString(),
                    Cargo = lista[13].ToString(),
                    Nota = lista[14].ToString(),
                    NombreMes = formatoFecha.GetMonthName(mess),
                    NombreDia = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek),
                }); 
            }

            return Agregar;
        }
    }
}
