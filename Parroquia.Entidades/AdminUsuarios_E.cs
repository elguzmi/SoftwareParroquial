using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Parroquia.Entidades
{
    public class AdminUsuarios_E
    {
        // declarar parametros que vamos a usar 
        // son los atributos o caracterisitcas que todo parametro contiene es decir Nombr= Doc  Objeto= valor Tipo de dato = varchar  tamaño= 10  direccion de parametro
        public String Nombre { set; get; }
        public Object Valor { set; get; }         // recupera un valor
        public SqlDbType TipoDato { set; get; }   // manejar tipos de datos de sql server ya que los tipos de datos de sql server y sql estudio no llevan lso mismo nombres
        public Int32 Tamaño { set; get; }
        public ParameterDirection Direccion { set; get; }



        public AdminUsuarios_E(String objNombre, Object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            Direccion = ParameterDirection.Input;
        }

        public AdminUsuarios_E(String objNombre, SqlDbType objTipoDato, Int32 objTamaño)
        {
            Nombre = objNombre;
            TipoDato = objTipoDato;
            Tamaño = objTamaño;
            Direccion = ParameterDirection.Output;

        }
    }


    //   Constructores


 
}
