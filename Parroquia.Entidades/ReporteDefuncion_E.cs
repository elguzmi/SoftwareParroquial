using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parroquia.Entidades
{
    public class ReporteDefuncion_E
    {

        public string No_Defuncion { get; set; }
        public string Libro { get; set; }
        public string Folio { get; set; }
        public string Numero { get; set; }
        public string Fecha_Sepelio { get; set; }
        public string Nombre_Difunto { get; set; }

   
        public string Ciudad_Origen { get; set; }
        public string Edad { get; set; }
        public string Padres { get; set; }
        public string Estado_Civil { get; set; }
        public string Ocacion_Muerte { get; set; }
        public string DoyFe { get; set; }
        public string Nombre_Firmante { get; set; }
        public string Cargo{ get; set; }
        public string Nota { get; set; }

        public string NombreMes { get; set; }

        public string NombreDia { get; set; }


        public ReporteDefuncion_E()
        {

        }

        public ReporteDefuncion_E(ReporteDefuncion_E Add)
        {
            
            No_Defuncion = Add.No_Defuncion;
            Libro = Add.Libro;
            Folio = Add.Folio;
            Numero = Add.Numero;
            Fecha_Sepelio = Add.Fecha_Sepelio;
            Nombre_Difunto = Add.Nombre_Difunto;

            Ciudad_Origen = Add.Ciudad_Origen;
            Edad = Add.Edad;
           
            Padres = Add.Padres;
            Estado_Civil = Add.Estado_Civil;
            Ocacion_Muerte = Add.Ocacion_Muerte;
            DoyFe = Add.DoyFe;
            Nombre_Firmante = Add.Nombre_Firmante;
            Cargo = Add.Cargo;
            Nota = Add.Nota;

            NombreDia = Add.NombreDia;

            NombreMes = Add.NombreMes;
        }
    }
}
