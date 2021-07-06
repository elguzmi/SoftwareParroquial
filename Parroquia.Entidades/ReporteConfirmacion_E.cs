using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parroquia.Entidades
{
    public class ReporteConfirmacion_E
    {

        public string Codigo_Partida{ get; set; }
        public string Libro { get; set; }
        public string Folio { get; set; }
        public string Numero { get; set; }
        public string FechaConfirmacion { get; set; }
        public string Nombre_Confirmado { get; set; }

   
        public string Lugar_Nacimiento { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Padres { get; set; }
        public string ParroquiaB { get; set; }
        public string Diocesis { get; set; }
        public string FechaB { get; set; }
        
        public string Libro_B{ get; set; }
        public string Folio_B{ get; set; }
        public string Numero_B{ get; set; }

        //Datos Generales

        public string Padrinos { get; set; }
        public string Ministro { get; set; }
        public string DoyFe { get; set; }
        public string Nota { get; set; }
        public string Nombre_Firmante { get; set; }
        public string Cargo { get; set; }

        public string NombreMes { get; set; }

        public string NombreDia { get; set; }

        public ReporteConfirmacion_E()
        {

        }

        public ReporteConfirmacion_E(ReporteConfirmacion_E Add)
        {
            
            Codigo_Partida = Add.Codigo_Partida;
            Libro = Add.Libro;
            Folio = Add.Folio;
            Numero = Add.Numero;
            FechaConfirmacion = Add.FechaConfirmacion;
            Nombre_Confirmado = Add.Nombre_Confirmado;

            Lugar_Nacimiento = Add.Lugar_Nacimiento;
            Fecha_Nacimiento = Add.Fecha_Nacimiento;
            Padres = Add.Padres;
            ParroquiaB = Add.ParroquiaB;
            Diocesis = Add.Diocesis;
            FechaB = Add.FechaB;
            Libro_B = Add.Libro_B;

            Folio_B = Add.Folio_B;
            Numero_B = Add.Numero_B;
            Padrinos = Add.Padrinos;
            Ministro = Add.Ministro;
            DoyFe = Add.DoyFe;
            Nota = Add.Nota;
            Nombre_Firmante = Add.Nombre_Firmante;

            Cargo = Add.Cargo;

            NombreDia = Add.NombreDia;

            NombreMes = Add.NombreMes;
            





        }
    }
}
