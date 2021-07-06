using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Parroquia.Negocio;

namespace Parroquia_Windows
{
    public partial class FormAdminUsuarios : Form
    {
        AdminUsuarios_N usuariosD = new AdminUsuarios_N();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // width of ellipse
              int nHeightEllipse // height of ellipse
          );
        public FormAdminUsuarios()
        {


            InitializeComponent();
           // this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void FormAdminUsuarios_Load(object sender, EventArgs e)
        {
            Txt_NoUsuario.ReadOnly = true;
            cargarDatos();
        }

        private void cargarDatos()
        {
            DataTable tabla = new DataTable();
            tabla = usuariosD.ListarUsuarios();
            DgvUsuarios.DataSource = tabla;

            LCargo.SelectedIndex = 0;
        }


        private void LimpiarControl(Control Contenedor)
        {
            foreach (var item in Contenedor.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Clear();
                }
            }
            LCargo.SelectedIndex = 0;

        }

        private void ActivarControlDatos(Control Contenedor, bool Estado)
        {
            try
            {
                foreach (var item in Contenedor.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).Enabled = Estado;
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormModulosAdminFir Atras = new FormModulosAdminFir();
            this.Hide();
            Atras.Show();
        }

        int Valor;
        public int Convertidor(String Cargo)
        {
            
            if (Cargo == "Selecciona")
            {
                Valor = 0;
            }
            else
            {
                if (Cargo == "Administrador")
                {
                    Valor = 1;
                }
                else if (Cargo == "Asistente")
                {
                    Valor = 2;

                }
            }
            return Valor;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (BtnAgregar.Text == "Guardar")
            {
                String msj = "";

                string Cargo = LCargo.SelectedItem.ToString();
                int Tipo = Convertidor(Cargo);

                if (Tipo == 0 || TxtNombre.Text=="" || TxtClave.Text == "")
                {
                    MessageBox.Show("Completa los campos para poder registrar");
                }
                else
                {
                    usuariosD.No_Usuario = int.Parse(Txt_NoUsuario.Text);
                    usuariosD.Nombre_Usuario = TxtNombre.Text;
                    usuariosD.Clave = TxtClave.Text;
                    usuariosD.Tipo_User = Tipo;

                    msj = usuariosD.EditarUsuario();
                    MessageBox.Show(msj);

                    LimpiarControl(Gb_Datos1);
                    cargarDatos();
                    BtnAgregar.Text = "Agregar";
                    BtnBorrar.Text = "Borrar";
                }
                

            }
            else
            {

                string Cargo = LCargo.SelectedItem.ToString();
                int Tipo = 0;
                String msj = "";

                if (Cargo == "Selecciona" || TxtNombre.Text == "" || TxtClave.Text == "")
                {
                    msj = "completa los campos para completar el registro";
                }
                else
                {
                    if (Cargo == "Administrador")
                    {
                        Tipo = 1;
                    }
                    else if (Cargo == "Asistente")
                    {
                        Tipo = 2;

                    }
                    usuariosD.No_Usuario = 0;
                    usuariosD.Nombre_Usuario = TxtNombre.Text;
                    usuariosD.Clave = TxtClave.Text;
                    usuariosD.Tipo_User = Tipo;

                    msj = usuariosD.InsertarUsuario();
                    
                    LimpiarControl(Gb_Datos1);

                }

                MessageBox.Show(msj);
                cargarDatos();


            }
           
           
        }

        private void LCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string Cargo = LCargo.SelectedItem.ToString();
            //MessageBox.Show(Cargo);
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

            if (BtnBorrar.Text == "Cancelar")
            {
                LimpiarControl(Gb_Datos1);
                BtnAgregar.Text = "Guardar";
                BtnBorrar.Text = "Borrar";

            }
            else
            {

                string Id = DgvUsuarios[0, DgvUsuarios.CurrentRow.Index].Value.ToString();


                DialogResult rpta =

                       MessageBox.Show("Desea eliminar el registro" + Id, "Eliminar",


                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rpta == System.Windows.Forms.DialogResult.Yes)
                {
                    String msj = "";
                    usuariosD.No_Usuario = int.Parse(Id);

                    msj = usuariosD.EliminarUsuario();
                    MessageBox.Show(msj);
                    cargarDatos();
                    LimpiarControl(Gb_Datos1);
                }


            }
           

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            bool Actualizar= true;
            BtnBorrar.Text = "Cancelar";
            BtnAgregar.Text = "Guardar";


            string Id = DgvUsuarios[0, DgvUsuarios.CurrentRow.Index].Value.ToString();
            string Nombre =DgvUsuarios[1, DgvUsuarios.CurrentRow.Index].Value.ToString();
            string CLave = DgvUsuarios[2, DgvUsuarios.CurrentRow.Index].Value.ToString();
            string Tipo = DgvUsuarios[3, DgvUsuarios.CurrentRow.Index].Value.ToString();

            Txt_NoUsuario.Text = Id;
            TxtNombre.Text = Nombre;
            TxtClave.Text = CLave;
            
            if(Tipo == "Administrador")
            {
                LCargo.SelectedIndex = 1;
            }
            else if (Tipo == "Asistente")
            {
                LCargo.SelectedIndex = 2;
            }
        }
    }
}
