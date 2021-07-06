using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parroquia.Entidades;
using Parroquia.Negocio;

namespace Parroquia_Windows
{
    public partial class BuscarBautismo : Form
    {
        Bautismo_N N = new Bautismo_N();
        public BuscarBautismo()
        {
            InitializeComponent();
        }

        private void BuscarBautismo_Load(object sender, EventArgs e)
        {
            DgvBautismos.DataSource = N.ListarBautismo();
            TxtNombre.Enabled = false;
            TxtPartida.Enabled = false;
        }

        private void DgvBautismos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string CodigoPartida="";
            
            try {
                CodigoPartida = DgvBautismos[0, DgvBautismos.CurrentRow.Index].Value.ToString();
                TxtPartida.Text = CodigoPartida.ToString();
                TxtNombre.Text = DgvBautismos[4, DgvBautismos.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No has seleccionado nada");
            }
            

        }

        private void TxtBuscarPartida_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                N.PartidaCodigo =TxtBuscarPartida.Text;

                DataTable Tabla = N.BuscarPartida();
                DgvBautismos.DataSource = Tabla;
            }
            catch
            {
                DgvBautismos.DataSource = N.ListarBautismo();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea eliminar el registro", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string partida = TxtPartida.Text;

                try
                {
                    N.PartidaCodigo = partida;
                    string msj = "";
                    msj = N.Eliminar();
                    MessageBox.Show(msj);

                    if (msj != "")
                    {
                        DgvBautismos.DataSource = N.ListarBautismo();
                    }

                }
                catch
                {
                    MessageBox.Show("Error verifica los datos");
                }

            }
            else
            {

            }   

            
        }

        private void TxtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtBuscarporNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                N.Nombre =(TxtBuscarporNombre.Text);

                DataTable Tabla = N.BuscarporNombre();
                DgvBautismos.DataSource = Tabla;
            }
            catch
            {
                DgvBautismos.DataSource = N.ListarBautismo();
            }
        }

        private void TxtBuscarporPadres_TextChanged(object sender, EventArgs e)
        {
            try
            {
                N.Padres = (TxtBuscarporPadres.Text);

                DataTable Tabla = N.BuscarporPadres();
                DgvBautismos.DataSource = Tabla;
            }
            catch
            {
                DgvBautismos.DataSource = N.ListarBautismo();
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try {
                string Codigo = TxtPartida.Text;
                Reportes.ReporteBautismo report = new Reportes.ReporteBautismo(Codigo);
                report.Show();
            }
            catch
            {
                MessageBox.Show("No has seleccionado nada");
            }
            
        }
    }
}
