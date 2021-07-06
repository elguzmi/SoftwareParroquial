using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parroquia.Datos;
using Parroquia.Entidades;
using System.Data;

namespace Parroquia.Negocio
{
    public class AdminUsuarios_N
    {
        public int No_Usuario { get; set; }
        public String Nombre_Usuario { get; set;}
        public String Clave { get; set; }
        public int Tipo_User { get; set; }

        AdminUsuarios_D UsuariosD = new AdminUsuarios_D();

        public String InsertarUsuario()
        {
            String msj = "";
            List<AdminUsuarios_E> lst = new List<AdminUsuarios_E>();
            try
            {
                lst.Add(new AdminUsuarios_E("@Dato", 1));
                lst.Add(new AdminUsuarios_E("@No_Usuario", No_Usuario));
                lst.Add(new AdminUsuarios_E("@Usuario", Nombre_Usuario));
                lst.Add(new AdminUsuarios_E("@Tipo",Tipo_User));
                lst.Add(new AdminUsuarios_E("@Clave",Clave));


                //Parametros de salida
                lst.Add(new AdminUsuarios_E("@Mensaje", SqlDbType.VarChar, 100));

                UsuariosD.ejecutarsp("AdminUsuarios", lst);
                msj = lst[5].Valor.ToString();
                

            }catch(Exception ex)
            {
                throw ex;
            }

            return msj;
        }

        public DataTable ListarUsuarios()
        {
            List<AdminUsuarios_E> lst = new List<AdminUsuarios_E>();
            try
            {
                lst.Add(new AdminUsuarios_E("@Dato", 4));
                lst.Add(new AdminUsuarios_E("@No_Usuario", ""));
                lst.Add(new AdminUsuarios_E("@Usuario", ""));
                lst.Add(new AdminUsuarios_E("@Tipo", 0));
                lst.Add(new AdminUsuarios_E("@Clave", ""));
                lst.Add(new AdminUsuarios_E("@Mensaje", "nada"));

                return UsuariosD.listado("AdminUsuarios", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
                 // es null porque pasa una consulta sin condicionales
        }

        public String EditarUsuario()
        {
            String msj = "";
            List<AdminUsuarios_E> lst = new List<AdminUsuarios_E>();
            try
            {
                lst.Add(new AdminUsuarios_E("@Dato", 2));
                lst.Add(new AdminUsuarios_E("@No_Usuario", No_Usuario));
                lst.Add(new AdminUsuarios_E("@Usuario", Nombre_Usuario));
                lst.Add(new AdminUsuarios_E("@Tipo", Tipo_User));
                lst.Add(new AdminUsuarios_E("@Clave", Clave));


                //Parametros de salida
                lst.Add(new AdminUsuarios_E("@Mensaje", SqlDbType.VarChar, 100));

                UsuariosD.ejecutarsp("AdminUsuarios", lst);
                msj = lst[5].Valor.ToString();


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }

        public String EliminarUsuario()
        {
            String msj = "";
            List<AdminUsuarios_E> lst = new List<AdminUsuarios_E>();
            try
            {
                lst.Add(new AdminUsuarios_E("@Dato", 3));
                lst.Add(new AdminUsuarios_E("@No_Usuario", No_Usuario));
                lst.Add(new AdminUsuarios_E("@Usuario", ""));
                lst.Add(new AdminUsuarios_E("@Tipo", ""));
                lst.Add(new AdminUsuarios_E("@Clave", ""));

                //Parametros de salida
                lst.Add(new AdminUsuarios_E("@Mensaje", SqlDbType.VarChar, 100));

                UsuariosD.ejecutarsp("AdminUsuarios", lst);
                msj = lst[5].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return msj;
        }



    }

   
}
