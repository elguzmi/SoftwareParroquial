using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;


namespace Parroquia.Entidades
{
    public class ReporteMatrimonio_E
    {

        public string Codigo_Partida { get; set; }
        public string Libro { get; set; }
        public string Folio { get; set; }
        public string Numero { get; set; }
        public string FechaMatrimonio { get; set; }
        public string Presencio { get; set; }

        //Datos del novio
        public string Nombre_Novio { get; set; }
        public string Padres_Novio { get; set; }
        public string Parroquia_Novio { get; set; }
        public string Fecha_Bautismo_Novio { get; set; }
        public string Libro_Novio { get; set; }
        public string Folio_Novio { get; set; }
        public string Acta_Novio { get; set; }

        //Datos de la novia

        public string Nombre_Novia { get; set; }
        public string Padres_Novia { get; set; }
        public string Parroquia_Novia { get; set; }
        public string Fecha_Bautismo_Novia { get; set; }
        public string Libro_Novia { get; set; }
        public string Folio_Novia { get; set; }
        public string Acta_Novia { get; set; }

        //Datos Generales

        public string Testigos { get; set; }
        public string DoyFe { get; set; }

       
        
        
        public string Nota_Marginal { get; set; }

        public List<String> Notica { get; set; }

        public string[] array { get; set; }
        public string Nombre_Firmante { get; set; }
        public string Cargo { get; set; }

        public string NombreMes { get; set; }
        public string NombreDia { get; set; }

        public ReporteMatrimonio_E()
        {

        }

        public ReporteMatrimonio_E(ReporteMatrimonio_E Add)
        {
            
            Codigo_Partida = Add.Codigo_Partida;
            Libro = Add.Libro;
            Folio = Add.Folio;
            Numero = Add.Numero;
            FechaMatrimonio = Add.FechaMatrimonio;
            Presencio = Add.Presencio;
            //Datos Novio
            Nombre_Novio = Add.Nombre_Novio;    
            Padres_Novio = Add.Padres_Novio;
            Parroquia_Novio = Add.Parroquia_Novio;
            Fecha_Bautismo_Novio = Add.Fecha_Bautismo_Novio;
            Libro_Novio = Add.Libro_Novio;
            Folio_Novio = Add.Folio_Novio;
            Acta_Novio = Add.Acta_Novio;

            //Datos Novia

            Nombre_Novia = Add.Nombre_Novia;
            Padres_Novia = Add.Padres_Novia;
            Parroquia_Novia = Add.Parroquia_Novia;
            Fecha_Bautismo_Novia = Add.Fecha_Bautismo_Novia;
            Libro_Novia = Add.Libro_Novia;
            Folio_Novia = Add.Folio_Novia;
            Acta_Novia = Add.Acta_Novia;

            //Datos Generales

            Testigos = Add.Testigos;
            DoyFe = Add.DoyFe;
            Nota_Marginal = Add.Nota_Marginal;

            Notica = Add.Notica;

            array = Add.array;
            
            //Lista = GetText(Nota_Marginal, 8);
            
            Nombre_Firmante = Add.Nombre_Firmante;
            Cargo = Add.Cargo;
            NombreDia = Add.NombreDia;
            NombreMes = Add.NombreMes;

        }

        


    }
}
