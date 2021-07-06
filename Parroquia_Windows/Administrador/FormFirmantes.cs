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
    public partial class FormFirmantes : Form
    {
        Firmantes_N N = new Firmantes_N();
        bool _editar = false;
        
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
        public FormFirmantes()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            CargarDatos();
        }

        private void FormFirmantes_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            DgvMinistros.DataSource = N.ListarMinistros();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormModulosAdminFir Atras = new FormModulosAdminFir();
            this.Hide();
            Atras.Show();
        }

        private void DgvMinistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Ministro;
            string No;
            try
            {
                Ministro = DgvMinistros[1, DgvMinistros.CurrentRow.Index].Value.ToString();
                No = DgvMinistros[0, DgvMinistros.CurrentRow.Index].Value.ToString();
                TxtMinistro.Text = Ministro;
                TxtNoFirmante.Text = No;

            }
            catch
            {
                MessageBox.Show("No has seleccionado nada");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (BtnAgregar.Text == "Guardar Firmante")
            {
                try
                {
                    N.Nombre = TxtFirmante.Text;
                    N.Cargo = CmbCargo.Text;


                    String msj = N.InsertarFirmante();
                    if (msj != "")
                    {
                        MessageBox.Show(msj);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
                catch
                {
                    MessageBox.Show("Completa los campos");
                }
            }
            else
            {
                if (_editar== true)
                {
                    try
                    {
                        N.No_Firmante = int.Parse(TxtNo.Text);
                        N.Nombre = TxtFirmante.Text;
                        N.Cargo = CmbCargo.Text;
                        string msj = N.EditarFirmante();
                        if(msj != "")
                        {
                            MessageBox.Show(msj);
                            _editar = false;
                            BtnAgregar.Text = "Guardar Firmante";
                            CargarDatos();
                        }

                    }
                    catch
                    {

                    }
                    
                }
                
            }
            
            
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                N.No_Firmante = int.Parse(TxtNoFirmante.Text);

               
            }
            catch
            {
                MessageBox.Show("Selecciona un registro");
            }
            DataTable Tabla = N.TraerFimante();

            TxtNo.Text = Tabla.Rows[0]["Id_Firmante"].ToString();
            TxtFirmante.Text = Tabla.Rows[0]["Nombre_Firmante"].ToString();
            CmbCargo.Text = Tabla.Rows[0]["Cargo"].ToString();
            _editar = true;
            BtnAgregar.Text = "Guardar Cambios";


        }
    }
}
