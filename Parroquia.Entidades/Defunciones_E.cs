using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Parroquia.Entidades
{
    public class Defunciones_E
    {
        public String Nombre { set; get; }
        public Object Valor { set; get; }
        public SqlDbType TipoDato { set; get; }
        public Int32 Tamaño { set; get; }
        public ParameterDirection Direccion { set; get; }
        //----------------------------------------------------------------------------------------------------------------


        // contructor de Entrada

        public Defunciones_E(String objNombre, Object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            Direccion = ParameterDirection.Input;
        }



        // contructor de salida
        public Defunciones_E(String objNombre, SqlDbType objTipoDato, Int32 objTamaño)
        {
            Nombre = objNombre;
            TipoDato = objTipoDato;
            Tamaño = objTamaño;
            Direccion = ParameterDirection.Output;
        }

    }
}
