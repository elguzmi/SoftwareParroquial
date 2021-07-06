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
    public partial class RegistrosMatrimonio : Form
    {
        Matrimonio_N MatriN = new Matrimonio_N();

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
        public RegistrosMatrimonio()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
           // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void RegistrosMatrimonio_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {

            DataTable tabla = new DataTable();
            tabla = MatriN.ListarMatrimonios();
            DgvMatrimonios.DataSource = tabla;
            TxtPartida.Enabled = false;
            TxtNombre.Enabled = false;
        }
       

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvMatrimonios_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void DgvMatrimonios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string CodigoPartida;
            try
            {
                CodigoPartida = DgvMatrimonios[0, DgvMatrimonios.CurrentRow.Index].Value.ToString();
                TxtPartida.Text = CodigoPartida;
                TxtNombre.Text= DgvMatrimonios[6, DgvMatrimonios.CurrentRow.Index].Value.ToString();

            }
            catch
            {
                MessageBox.Show("No has selecconado nada");
            }

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea eliminar el registro", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                MatriN.PartidaCodigo = TxtPartida.Text;

                string msj = " ";

                msj = MatriN.EliminarMatrimonio();


                MessageBox.Show(msj);

                if(msj != "")
                {
                    CargarDatos();
                }

            }
            else
            {
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Reportes.ReporteMatrimonio report = new Reportes.ReporteMatrimonio(TxtPartida.Text);
                report.Show();
            }
            catch
            {
                MessageBox.Show("No has seleccionado ningun registro");
            }
            
        }

        private void TxtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String codigo = TxtBuscarCodigo.Text;
                MatriN.PartidaCodigo = codigo;
                DgvMatrimonios.DataSource = MatriN.BuscarPorCodigo();
            }
            catch
            {
                DgvMatrimonios.DataSource = MatriN.ListarMatrimonios();
            }
        }

        private void TxtBuscarNovio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Novio = TxtBuscarNovio.Text;
                MatriN.Nombre_Novio = Novio;
                DgvMatrimonios.DataSource = MatriN.BuscarPorNovio();
            }
            catch
            {
                DgvMatrimonios.DataSource = MatriN.ListarMatrimonios();
            }
            
        }

        private void TxtBuscarNovia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String Novia = TxtBuscarNovia.Text;
                MatriN.Nombre_Novia = Novia;
                DgvMatrimonios.DataSource = MatriN.BuscarPorNovia();
            }
            catch
            {
                DgvMatrimonios.DataSource = MatriN.ListarMatrimonios();
            }
           
        }


        //celda de click
        private void DgvMatrimonios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string CodigoPartida;
            try
            {
                CodigoPartida = DgvMatrimonios[0, DgvMatrimonios.CurrentRow.Index].Value.ToString();
                TxtPartida.Text = CodigoPartida;
                TxtNombre.Text = DgvMatrimonios[6, DgvMatrimonios.CurrentRow.Index].Value.ToString();

            }
            catch
            {
                MessageBox.Show("No has selecconado nada");
            }
        }
    }
}
