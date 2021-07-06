using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parroquia.Entidades;
using Parroquia.Datos;
using System.Data;
using System.Globalization;
using System.Text;

namespace Parroquia.Negocio
{
    public class ReporteMatrimonio_N
    {
        DateTimeFormatInfo formatoFecha = new CultureInfo("es-MX", false).DateTimeFormat;
        CultureInfo ci = new CultureInfo("Es-Es");
        int mess = DateTime.Now.Month;
        public List<ReporteMatrimonio_E>Listar(string Codigo)
        {
            List<ReporteMatrimonio_E> Agregar = new List<ReporteMatrimonio_E>();
            ReporteMatrimonio_D ReporteD = new ReporteMatrimonio_D();
            foreach (DataRow lista in ReporteD.Datos(Codigo).Rows)
            {
                Agregar.Add(new ReporteMatrimonio_E
                {

                    Codigo_Partida = lista[0].ToString(),
                    Libro = lista[1].ToString(),
                    Folio = lista[2].ToString(),
                    Numero = lista[3].ToString(),
                    FechaMatrimonio = lista[4].ToString(),
                    Presencio = lista[5].ToString(),
                    //Datos novio
                    Nombre_Novio = lista[6].ToString(),
                    Padres_Novio = lista[7].ToString(),
                    Parroquia_Novio = lista[8].ToString(),
                    Fecha_Bautismo_Novio = lista[9].ToString(),
                    Libro_Novio = lista[10].ToString(),
                    Folio_Novio = lista[11].ToString(),
                    Acta_Novio = lista[12].ToString(),
                    //datos novia
                    Nombre_Novia = lista[13].ToString(),
                    Padres_Novia = lista[14].ToString(),
                    Parroquia_Novia = lista[15].ToString(),
                    Fecha_Bautismo_Novia = lista[16].ToString(),
                    Libro_Novia = lista[17].ToString(),
                    Folio_Novia = lista[18].ToString(),
                    Acta_Novia = lista[19].ToString(),
                    // datos generales
                    Testigos = lista[20].ToString(),
                    DoyFe = lista[21].ToString(),
                    Nota_Marginal = lista[22].ToString(),
                    Notica = GetText(lista[22].ToString(),200),
                    array = GetText(lista[22].ToString(), 200).ToArray(),
                    

                Nombre_Firmante = lista[23].ToString(),
                    Cargo = lista[24].ToString(),

                    NombreMes = formatoFecha.GetMonthName(mess),
                    NombreDia = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek),
                }) ; 
            }
            return Agregar;
        }



        public static List<string> GetText(string text, int width)
        {
            string[] palabras = text.Split(' ');
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            int length = palabras.Length;
            List<string> resultado = new List<string>();
            for (int i = 0; i < length; i++)
            {
                sb1.AppendFormat("{0} ", palabras[i]);
                if (sb1.ToString().Length > width)
                {
                    resultado.Add(sb2.ToString());
                    sb1 = new StringBuilder();
                    sb2 = new StringBuilder();
                    i--;
                }
                else
                {
                    sb2.AppendFormat("{0} ", palabras[i]);
                }
            }
            resultado.Add(sb2.ToString());

            List<string> resultado2 = new List<string>();
            string temp;

            int index1, index2, salto;
            string target;
            int limite = resultado.Count;
            foreach (var item in resultado)
            {
                target = " ";
                temp = item.ToString().Trim();
                index1 = 0; index2 = 0; salto = 2;

                if (limite <= 1)
                {
                    resultado2.Add(temp);
                    break;
                }
                while (temp.Length <= width)
                {
                    if (temp.IndexOf(target, index2) < 0)
                    {
                        index1 = 0; index2 = 0;
                        target = target + " ";
                        salto++;
                    }
                    index1 = temp.IndexOf(target, index2);
                    temp = temp.Insert(temp.IndexOf(target, index2), " ");
                    index2 = index1 + salto;

                }
                limite--;
                resultado2.Add(temp);
            }
            return resultado2;
        }


    }
}
