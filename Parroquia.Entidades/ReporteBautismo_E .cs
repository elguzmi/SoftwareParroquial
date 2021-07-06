using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Parroquia.Entidades
{
    public class ReporteBautismo_E
    {
        DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;

        public string Codigo_Partida{ get; set; }
        public string Libro { get; set; }
        public string Folio { get; set; }
        public string Numero { get; set; }
        public string Nombre { get; set; }
        public string Fecha_Bautismo { get; set; }
        public string Ministro { get; set; }
        public string Lugar_Nacimiento { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Nombre_Padres { get; set; }
        public string Abuelos_Paternos { get; set; }
        public string AbuelosMaternos { get; set; }
        public string Padrinos { get; set; }
        public string Nombre_DoyFe { get; set; }
        
        
        public string Nota { get; set; }
        public List<String> textonota { get; set; }
        public string Nombre_Firmante { get; set; }
        public string Cargo { get; set; }
        public string mes { get; set; }
       
        public string mesesito { get; set; }

        public ReporteBautismo_E()
        {

            
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

        public ReporteBautismo_E(ReporteBautismo_E Add)
        {
            //15 objetos en la lista
            Codigo_Partida = Add.Codigo_Partida;
            Libro = Add.Libro;
            Folio = Add.Folio;
            Numero = Add.Numero;
            Nombre = Add.Nombre;
            Fecha_Bautismo = Add.Fecha_Bautismo;
            Ministro = Add.Ministro;
            Lugar_Nacimiento = Add.Lugar_Nacimiento;
            Fecha_Nacimiento = Add.Fecha_Nacimiento;
            Abuelos_Paternos = Add.Abuelos_Paternos;
            AbuelosMaternos = Add.AbuelosMaternos;

            Padrinos = Add.Padrinos;

            Nombre_DoyFe = Add.Nombre_DoyFe;

           



            Nota = Add.Nota;

            textonota = GetText(Nota, 10);

           Nombre_Firmante = Add.Nombre_Firmante;

            Cargo = Add.Cargo;

            mes = Add.mes;

            mesesito = Add.mesesito;

            

        }
       
       
    }
    
}
