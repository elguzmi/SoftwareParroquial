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
    public class ReporteBautismo_N
    {
        DateTimeFormatInfo formatoFecha = new CultureInfo("es-MX", false).DateTimeFormat;
        CultureInfo ci = new CultureInfo("Es-Es");
        int mess = DateTime.Now.Month;

        //int Day = DateTime.Now.Day;

       

       
        public List<ReporteBautismo_E> Listar(string  Codigo)
        {

            
            List<ReporteBautismo_E> Agregar = new List<ReporteBautismo_E>();
            ReporteBautismo_D ReporteD = new ReporteBautismo_D();
            foreach (DataRow lista in ReporteD.Datos(Codigo).Rows)
            {
                Agregar.Add(new ReporteBautismo_E
                {

                    Codigo_Partida = lista[0].ToString(),
                    Libro = lista[1].ToString(),
                    Folio = lista[2].ToString(),
                    Numero = lista[3].ToString(),
                    Nombre = lista[4].ToString(),
                    Fecha_Bautismo = lista[5].ToString(),
                    Ministro = lista[6].ToString(),
                    Lugar_Nacimiento = lista[7].ToString(),
                    Fecha_Nacimiento = lista[8].ToString(),
                    Nombre_Padres = lista[9].ToString(),
                    Abuelos_Paternos = lista[10].ToString(),
                    AbuelosMaternos = lista[11].ToString(),

                    Padrinos = lista[12].ToString(),

                    Nombre_DoyFe = lista[13].ToString(),

                   

                    Nota = lista[14].ToString() ,

                    Nombre_Firmante = lista[15].ToString(),

                    Cargo = lista[16].ToString(),

                    mesesito = formatoFecha.GetMonthName(mess),

                    mes = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek),

                    
                

                
                

            });
            }
            
            
            return Agregar;
        }
    }
}
