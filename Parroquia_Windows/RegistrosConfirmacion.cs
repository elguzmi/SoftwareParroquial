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
using Parroquia.Entidades;
using Parroquia.Negocio;


namespace Parroquia_Windows
{
    public partial class RegistrosConfirmacion : Form
    {


        Confirmaciones_N N = new Confirmaciones_N();

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
        public RegistrosConfirmacion()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            CargarDatos();

        }
        private void CargarDatos()
        {
            DgvConfirmaciones.DataSource = N.ListarConfirmaciones();
            TxtNombre.Enabled = false;
            TxtPartida.Enabled = false;
        }


        private void RegistrosConfirmacion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DgvConfirmaciones_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CodigoPartida;
            try
            {
                CodigoPartida = int.Parse(DgvConfirmaciones[0, DgvConfirmaciones.CurrentRow.Index].Value.ToString());
                TxtPartida.Text = CodigoPartida.ToString();
                TxtNombre.Text = DgvConfirmaciones[5, DgvConfirmaciones.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea eliminar el registro", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    String codigo = TxtPartida.Text;

                    N.Codigo_Partida = codigo;
                    string msj = "";

                    msj = N.Eliminar();

                    if (msj != "")
                    {
                        MessageBox.Show(msj);
                        CargarDatos();
                    }
                }
                catch
                {
                    MessageBox.Show("No has seleccionado ningun registro");
                }
            }
            else
            {

            }
            
        }

        private void TxtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String codigo = TxtBuscarCodigo.Text;
                N.Codigo_Partida = codigo;
                DgvConfirmaciones.DataSource = N.BuscarPartida();
            }
            catch
            {
                CargarDatos();
            }
           
        }

        private void TxtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Nombre = TxtBuscarNombre.Text;
                N.Nombre_Confirmado = Nombre;
                DgvConfirmaciones.DataSource = N.BuscarporNombre();
            }
            catch
            {
                CargarDatos();
            }
            
        }

        private void TxtBuscarPadres_TextChanged(object sender, EventArgs e)
        {

            try
            {
                String padres = TxtBuscarPadres.Text;
                N.Padres = padres;
                DgvConfirmaciones.DataSource = N.BuscarporPadres();
            }
            catch
            {
                CargarDatos();
            }
           
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Reportes.ReporteConfirmacion reporte = new Reportes.ReporteConfirmacion(TxtPartida.Text);
                reporte.Show();
            }
            catch
            {
                MessageBox.Show("No has seleccionado ningun registros");
            }
            
        }

        private void DgvConfirmaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CodigoPartida;
            try
            {
                CodigoPartida = int.Parse(DgvConfirmaciones[0, DgvConfirmaciones.CurrentRow.Index].Value.ToString());
                TxtPartida.Text = CodigoPartida.ToString();
                TxtNombre.Text = DgvConfirmaciones[5, DgvConfirmaciones.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void DgvConfirmaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CodigoPartida;
            try
            {
                CodigoPartida = int.Parse(DgvConfirmaciones[0, DgvConfirmaciones.CurrentRow.Index].Value.ToString());
                TxtPartida.Text = CodigoPartida.ToString();
                TxtNombre.Text = DgvConfirmaciones[5, DgvConfirmaciones.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
    }
}
