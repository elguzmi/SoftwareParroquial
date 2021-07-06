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
    public partial class Modulo_Matrimonio : Form
    {

        Matrimonio_N MatriN = new Matrimonio_N();
        bool _nuevo = false;
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
        public Modulo_Matrimonio()
        {
            InitializeComponent();
           // this.FormBorderStyle = FormBorderStyle.None;
           // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void Modulo_Matrimonio_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarcmbDoyfe();
            CargarcmbFirmantes();
            CargarNota();
            ActivarBoton(true);
        }

        private void ActivarBoton(bool estado)
        {
            BtnNuevo.Enabled = estado;
            BtnAgregar.Enabled = !estado;
        }

        private void CargarNota()
        {
            TxtNota.Text = "SIN NOTAS MARGINALES HASTA LA FECHA";
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
            TxtNumero.Clear();
            TxtFolio.Clear();
            TxtLibro.Clear();
            TxtFechaM.Clear();
            TxtTestigos.Clear();
            TxtNota.Clear();
            TxtCodigo.Clear();
            

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
                TxtNumero.Enabled = Estado;
                TxtFolio.Enabled = Estado;
                TxtLibro.Enabled = Estado;
                CmbPresencio.Enabled = Estado;
                TxtFechaM.Enabled = Estado;
                TxtTestigos.Enabled = Estado;
                TxtNota.Enabled = Estado;
                CmbDoyFe.Enabled = Estado;
                CmbFirmante.Enabled = Estado;
            }
            catch (Exception)
            {

            }
        }

        private void CargarcmbDoyfe()
        {
            DataTable data = MatriN.ListadoDoyFe(); // estamos llenando el data table con el metodo listado
            CmbDoyFe.DataSource = data;
            CmbDoyFe.DisplayMember = "Nombre_Firmante";
            CmbDoyFe.ValueMember = "Id_Firmante";

        }

        private void CargarcmbFirmantes()
        {
            DataTable dt = MatriN.ListadoMinistros(); // estamos llenando el data table con el metodo listado
            CmbFirmante.DataSource = dt;
            CmbFirmante.DisplayMember = "Nombre_Firmante";
            CmbFirmante.ValueMember = "Id_Firmante";
        }

        private void CargarDatos()
        {
          
            ActivarControlDatos(GbNovia, false);
            ActivarControlDatos(GbNovio, false);
           


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       

        private void TxtLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (_nuevo== true && _editar==false)
            {
                string CodigoPartida = TxtCodigo.Text;
                MatriN.PartidaCodigo = CodigoPartida;
                MatriN.Libro = TxtLibro.Text;
                MatriN.Folio = TxtFolio.Text;
                MatriN.Numero = TxtNumero.Text;

                MatriN.FechaMatrimonio = TxtFechaM.Text;
                MatriN.Presencio = CmbPresencio.Text;

                //Datos Novio
                MatriN.Nombre_Novio = TxtNombreNovio.Text;
                MatriN.Padres_Novio = TxtPadresNovio.Text;
                MatriN.Parroquia_Novio = TxtParroquiaH.Text;
                MatriN.Fecha_Bautismo_Novio = TxtFechaBautismoH.Text;
                MatriN.LibroNovio = TxtLibroH.Text;
                MatriN.Folio_Novio = TxtFolioH.Text;
                MatriN.Acta_Novio = TxtActaH.Text;

                //DatosNovia

                MatriN.Nombre_Novia = TxtNombreNovia.Text;
                MatriN.Padres_Novia = TxtPadresNovia.Text;
                MatriN.Parroquia_Novia = TxtParroquiaM.Text;
                MatriN.Fecha_Bautismo_Novia = TxtFechaBautismoM.Text;
                MatriN.LibroNovia = TxtLibroM.Text;
                MatriN.Folio_Novia = TxtFolioM.Text;
                MatriN.Acta_Novia = TxtActaM.Text;

                MatriN.Testigos = TxtTestigos.Text;
                MatriN.DoyFe = int.Parse(CmbDoyFe.SelectedValue.ToString());
                MatriN.NotaMarginal = TxtNota.Text;
                MatriN.Firmante = int.Parse(CmbFirmante.SelectedValue.ToString());


                String msj = "";
                msj = MatriN.InsertarMatrimonio();
                

                if(msj != "")
                {
                    if (msj == "Ya registraste este numero de partida")
                    {
                        MessageBox.Show(msj);
                    }
                    else
                    {
                        MessageBox.Show(msj);
                        if (MessageBox.Show("Desea Imprimir el registro", "Imprimir registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                Reportes.ReporteMatrimonio report = new Reportes.ReporteMatrimonio(TxtCodigo.Text);
                                report.Show();
                            }
                            catch
                            {
                                MessageBox.Show("No has seleccionado ningun registro");
                            }
                        }
                        else
                        {

                        }
                        LimpiarControl(GbNovia);
                        LimpiarControl(GbNovio);
                        ActivarControlDatos(GbNovio, false);
                        ActivarControlDatos(GbNovia, false);
                        CargarNota();
                        BtnActualizar.Text = "Editar";
                        _nuevo = false;
                        _editar = false;
                        ActivarBoton(true);

                    }
                }
            }
            else if(_editar== true)
            {

                try
                {
                    string CodigoPartida = TxtCodigo.Text;
                    MatriN.PartidaCodigo = CodigoPartida;


                    MatriN.FechaMatrimonio = TxtFechaM.Text;
                    MatriN.Presencio = CmbPresencio.Text;

                    //Datos Novio
                    MatriN.Nombre_Novio = TxtNombreNovio.Text;
                    MatriN.Padres_Novio = TxtPadresNovio.Text;
                    MatriN.Parroquia_Novio = TxtParroquiaH.Text;
                    MatriN.Fecha_Bautismo_Novio = TxtFechaBautismoH.Text;
                    MatriN.LibroNovio = TxtLibroH.Text;
                    MatriN.Folio_Novio = TxtFolioH.Text;
                    MatriN.Acta_Novio = TxtActaH.Text;

                    //DatosNovia

                    MatriN.Nombre_Novia = TxtNombreNovia.Text;
                    MatriN.Padres_Novia = TxtPadresNovia.Text;
                    MatriN.Parroquia_Novia = TxtParroquiaM.Text;
                    MatriN.Fecha_Bautismo_Novia = TxtFechaBautismoM.Text;
                    MatriN.LibroNovia = TxtLibroM.Text;
                    MatriN.Folio_Novia = TxtFolioM.Text;
                    MatriN.Acta_Novia = TxtActaM.Text;

                    MatriN.Testigos = TxtTestigos.Text;
                    MatriN.DoyFe = int.Parse(CmbDoyFe.SelectedValue.ToString());
                    MatriN.NotaMarginal = TxtNota.Text;
                    MatriN.Firmante = int.Parse(CmbFirmante.SelectedValue.ToString());


                    String msj = "";
                    msj = MatriN.EditarMatrimonio();
                    MessageBox.Show(msj);
                    if (msj != "")
                    {                        

                        if (MessageBox.Show("Desea Imprimir el registro", "Imprimir registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                Reportes.ReporteMatrimonio report = new Reportes.ReporteMatrimonio(TxtCodigo.Text);
                                report.Show();
                            }
                            catch
                            {
                                MessageBox.Show("No has seleccionado ningun registro");
                            }
                        }

                        //LimpiarControl(GbNovia);
                        //LimpiarControl(GbNovio);
                        //ActivarControlDatos(GbNovio, false);
                        //ActivarControlDatos(GbNovia, false);
                        //CargarNota();
                        _editar = true;
                       // BtnActualizar.Text = "Editar";
                        //ActivarBoton(true);
                    }
                }
                catch
                {
                    MessageBox.Show("Verifica los datos");
                }
               
            }
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if(_nuevo== true  && _editar== false)
            {
                BtnNuevo.Enabled = true;
                
                LimpiarControl(GbNovia);
                LimpiarControl(GbNovio);
                ActivarControlDatos(GbNovio, false);
                ActivarControlDatos(GbNovia, false);
                CargarNota();
                _editar = false;
                _nuevo = false;
                BtnActualizar.Text = "Editar";
                ActivarBoton(true);


            }
            else if (_editar==true)
            {
                LimpiarControl(GbNovia);
                LimpiarControl(GbNovio);
                ActivarControlDatos(GbNovio, false);
                ActivarControlDatos(GbNovia, false);
                CargarNota();
                _editar = false;
                _nuevo = false;
                BtnActualizar.Text = "Editar";
                BtnAgregar.Text = "Agregar Registro";
                ActivarBoton(true);
            }
            else
            {

                using (RegistrosMatrimonio Buscar = new RegistrosMatrimonio())
                {
                    if (Buscar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                        string codigopartida = "";
                        codigopartida = Buscar.TxtPartida.Text;

                        if(codigopartida != "")
                        {
                            try
                            {

                                codigopartida = Buscar.TxtPartida.Text;
                                BtnAgregar.Text = "Guardar Cambios";

                                MatriN.PartidaCodigo = codigopartida;

                                DataTable Tabla = new DataTable();

                                Tabla = MatriN.TraerMatrimonio();

                                string libro = Tabla.Rows[0]["Libro"].ToString();
                                string folio = Tabla.Rows[0]["Folio"].ToString();
                                string numero = Tabla.Rows[0]["Numero"].ToString();
                                TxtCodigo.Text = libro + folio + numero;
                                TxtLibro.Text = libro;
                                TxtFolio.Text = folio;
                                TxtNumero.Text = numero;

                                TxtFechaM.Text = Tabla.Rows[0]["Fecha_Matrimonio"].ToString();
                                CmbPresencio.Text = Tabla.Rows[0]["Presencio"].ToString();

                                //Datos Novio
                                TxtNombreNovio.Text = Tabla.Rows[0]["Nombre_Novio"].ToString();
                                TxtPadresNovio.Text = Tabla.Rows[0]["Padres_Novio"].ToString();
                                TxtParroquiaH.Text = Tabla.Rows[0]["Parroquia_Novio"].ToString();
                                TxtFechaBautismoH.Text = Tabla.Rows[0]["Fecha_Bautismo_Novio"].ToString();
                                TxtLibroH.Text = Tabla.Rows[0]["Libro_Novio"].ToString();
                                TxtFolioH.Text = Tabla.Rows[0]["Folio_Novio"].ToString();
                                TxtActaH.Text = Tabla.Rows[0]["Acta_Novio"].ToString();

                                //Datos Novia
                                TxtNombreNovia.Text = Tabla.Rows[0]["Novia"].ToString();
                                TxtPadresNovia.Text = Tabla.Rows[0]["Padres_Novia"].ToString();
                                TxtParroquiaM.Text = Tabla.Rows[0]["Parroquia_Novia"].ToString();
                                TxtFechaBautismoM.Text = Tabla.Rows[0]["Fecha_Bautismo_Novia"].ToString();
                                TxtLibroM.Text = Tabla.Rows[0]["Libro_Novia"].ToString();
                                TxtFolioM.Text = Tabla.Rows[0]["Folio_Novia"].ToString();
                                TxtActaM.Text = Tabla.Rows[0]["Acta_Novia"].ToString();


                                TxtTestigos.Text = Tabla.Rows[0]["Testigos"].ToString();

                                if (Tabla.Rows[0]["Doy_Fe"].ToString()==null || Tabla.Rows[0]["Doy_Fe"].ToString()=="")
                                {
                                    CmbDoyFe.SelectedValue = 4;
                                }
                                else
                                {
                                    CmbDoyFe.SelectedValue = Tabla.Rows[0]["Doy_Fe"].ToString();
                                }
                                
                                if(Tabla.Rows[0]["Nota_Marginal"].ToString()== "" || Tabla.Rows[0]["Nota_Marginal"].ToString() == null)
                                {
                                    TxtNota.Text = "SIN NOTAS MARGINALES HASTA LA FECHA";
                                }
                                else
                                {
                                    TxtNota.Text = Tabla.Rows[0]["Nota_Marginal"].ToString();
                                }
                                CmbFirmante.SelectedValue = int.Parse(Tabla.Rows[0]["Firmante"].ToString());


                                ActivarControlDatos(GbNovio, true);
                                ActivarControlDatos(GbNovia, true);

                                _editar = true;
                                _nuevo = false;
                                BtnActualizar.Text = "Cancelar";
                                ActivarBoton(false);
                            }
                            catch
                            {
                                MessageBox.Show("No has seleccionado ningun registro");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No seleccionaste ningun registro");
                        }

                       

                    }
                }

            }
                
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ActivarControlDatos(GbNovia, true);
            ActivarControlDatos(GbNovio, true);
            _nuevo = true;
            BtnNuevo.Enabled = false;
            BtnActualizar.Text = "Cancelar";
            ActivarBoton(false);
            TxtLibro.Focus();
        }
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Hide();
        }

        private void TxtLibroH_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtFolioH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtActaH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtLibroM_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtFolioM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtActaM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CmbFirmante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MatriN.Firmante = int.Parse(CmbFirmante.SelectedValue.ToString());
                DataTable Tabla = MatriN.TraerCargo();
                TxtCargo.Text = Tabla.Rows[0]["Cargo"].ToString();
            }
            catch
            {

            }
        }



        #region cambio de texto en textbox

        private void TxtLibro_TextChanged_1(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtLibro.MaxLength = 5;
        }

        #endregion

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtNumero.MaxLength = 5;
        }

        private void TxtFolio_TextChanged(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtFolio.MaxLength = 5;
        }

        private void TxtLibroH_TextChanged(object sender, EventArgs e)
        {
            TxtLibroH.MaxLength = 5;
        }

        private void TxtFolioH_TextChanged(object sender, EventArgs e)
        {
            TxtFolioH.MaxLength = 5;
        }

        private void TxtActaH_TextChanged(object sender, EventArgs e)
        {
            TxtActaH.MaxLength = 5;
        }

        private void TxtLibroM_TextChanged(object sender, EventArgs e)
        {
            TxtLibroM.MaxLength = 5;
        }

        private void TxtFolioM_TextChanged(object sender, EventArgs e)
        {
            TxtFolioM.MaxLength = 5;
        }

        private void TxtActaM_TextChanged(object sender, EventArgs e)
        {
            TxtActaM.MaxLength = 5;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Reportes.ReporteMatrimonio report = new Reportes.ReporteMatrimonio(TxtCodigo.Text);
                report.Show();
            }
            catch
            {
                MessageBox.Show("No has seleccionado ningun registro");
            }
        }
    }
}
