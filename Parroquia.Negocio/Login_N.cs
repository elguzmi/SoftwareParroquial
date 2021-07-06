using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parroquia.Datos;
using System.Data;
using Parroquia.Entidades;
// la biblioteca de clases negocio tiene referencia a entidades y a datos

namespace Parroquia.Negocio
{
    public class Login_N
    {
        Login_D datos = new Login_D();
        
        public DataTable N_Login(Login_E obje)
        {
            return datos.ingreso(obje);
        }
    }
}
