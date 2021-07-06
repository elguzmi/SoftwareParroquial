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
    public class ReporteConfirmacion_N
    {
        DateTimeFormatInfo formatoFecha = new CultureInfo("es-MX", false).DateTimeFormat;
        CultureInfo ci = new CultureInfo("Es-Es");
        int mess = DateTime.Now.Month;
        public List<ReporteConfirmacion_E>Listar(string Codigo)
        {
            List<ReporteConfirmacion_E> Agregar = new List<ReporteConfirmacion_E>();
            ReporteConfirmacion_D ReporteD = new ReporteConfirmacion_D();
            foreach (DataRow lista in ReporteD.Datos(Codigo).Rows)
            {
                Agregar.Add(new ReporteConfirmacion_E
                {

                    Codigo_Partida = lista[0].ToString(),
                    Libro = lista[1].ToString(),
                    Folio = lista[2].ToString(),
                    Numero = lista[3].ToString(),
                    FechaConfirmacion = lista[4].ToString(),
                    Nombre_Confirmado = lista[5].ToString(),
                    
                    Lugar_Nacimiento = lista[6].ToString(),
                    Fecha_Nacimiento = lista[7].ToString(),
                    Padres = lista[8].ToString(),
                    ParroquiaB = lista[9].ToString(),
                    Diocesis = lista[10].ToString(),
                    FechaB = lista[11].ToString(),
                    Libro_B = lista[12].ToString(),
                   
                    Folio_B = lista[13].ToString(),
                    Numero_B = lista[14].ToString(),
                    Padrinos = lista[15].ToString(),
                    Ministro = lista[16].ToString(),
                    DoyFe = lista[17].ToString(),
                    Nota = lista[18].ToString(),
                    Nombre_Firmante = lista[19].ToString(),
                 
                    Cargo = lista[20].ToString(),

                    NombreMes = formatoFecha.GetMonthName(mess),
                    NombreDia = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek),

                }); 
            }

            return Agregar;
        }
    }
}
