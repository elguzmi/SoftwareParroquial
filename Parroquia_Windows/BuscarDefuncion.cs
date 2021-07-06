using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parroquia.Negocio;

namespace Parroquia_Windows
{
    public partial class BuscarDefuncion : Form
    {
        Defunciones_N N = new Defunciones_N();
        public BuscarDefuncion()
        {
            InitializeComponent();
            CargarDatos();
            desactivarcampos(false);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                String No_Defuncion = TxtPartida.Text;
                Reportes.ReporteDefuncion reporte = new Reportes.ReporteDefuncion(No_Defuncion);
                reporte.Show();
            }
            catch
            {
                MessageBox.Show("No has seleccionado ningun registro");
            }
           
        }

        private void BuscarDefuncion_Load(object sender, EventArgs e)
        {

        }

        private void CargarDatos()
        {
            DgvDefunciones.DataSource = N.ListarDefunciones();
        }

        public void desactivarcampos(bool estado)
        {
            TxtPartida.Enabled = estado;
            TxtNombre.Enabled = estado;
        }

        private void DgvDefunciones_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CodigoPartida;
            try
            {
                CodigoPartida = int.Parse(DgvDefunciones[0, DgvDefunciones.CurrentRow.Index].Value.ToString());
                TxtPartida.Text = CodigoPartida.ToString();
                TxtNombre.Text = DgvDefunciones[5, DgvDefunciones.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
           
        }

        private void TxtBuscarPartida_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                N.No_Defuncion = TxtBuscarPartida.Text;
                DgvDefunciones.DataSource = N.BuscarPartida();
            }
            catch
            {
                CargarDatos();
            }
        }

        private void TxtBuscarporNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                N.Nombre = TxtBuscarporNombre.Text;
                DgvDefunciones.DataSource = N.BuscarporNombre();
            }
            catch
            {
                CargarDatos();
            }
            

        }

        private void TxtBuscarporPadres_TextChanged(object sender, EventArgs e)
        {
            try
            {
                N.Padres = TxtBuscarporPadres.Text;
                DgvDefunciones.DataSource = N.BuscarporPadres();
            }
            catch
            {
                CargarDatos();
            }

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea eliminar el registro", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    N.No_Defuncion = TxtPartida.Text;
                    string msj = N.Eliminar();
                    if (msj != "")
                    {
                        MessageBox.Show(msj);
                        CargarDatos();
                    }
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error");
                }

            }
            else
            {

            }
        }

        private void DgvDefunciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CodigoPartida;
            try
            {
                CodigoPartida = int.Parse(DgvDefunciones[0, DgvDefunciones.CurrentRow.Index].Value.ToString());
                TxtPartida.Text = CodigoPartida.ToString();
                TxtNombre.Text = DgvDefunciones[5, DgvDefunciones.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
    }
}
