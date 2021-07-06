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
    public partial class Modulo_DefuncionA : Form
    {

        Defunciones_N N = new Defunciones_N();
        bool _editar = false;
        bool _nuevo = false;

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
        public Modulo_DefuncionA()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            CargarDatos();
            ActivarControlDatos(gbDatos, false);
            ActivarBoton(true);
        }

        private void ActivarBoton(bool estado)
        {
            BtnNuevo.Enabled = estado;
            BtnAgregar.Enabled = !estado;
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


        private void LimpiarControl(Control Contenedor)
        {
            foreach (var item in Contenedor.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Clear();
                }
            }
        }
        private void ActivarButton(bool Estado)
        {
            BtnNuevo.Enabled = Estado;
            BtnAgregar.Enabled =! Estado;
            
            
        }
        private void CargarDatos()
        {
            DataTable dt = N.ListadoMinistros(); // estamos llenando el data table con el metodo listado
            CmbFirmante.DataSource = dt;
            CmbFirmante.DisplayMember = "Nombre_Firmante";
            CmbFirmante.ValueMember = "Id_Firmante";
        }

        private void Modulo_Defuncion_Load(object sender, EventArgs e)
        {

        }

        private void CargarNota()
        {
            TxtNota.Text = "SIN NOTAS MARGINALES HASTA LA FECHA";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormPrincipalA ir = new FormPrincipalA();
            this.Hide();
            ir.Show();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {


        }

        private void TxtLibro_TextChanged(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtLibro.MaxLength = 5;
           
        }

        private void TxtFolio_TextChanged(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtLibro.MaxLength = 5;
            
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtLibro.MaxLength = 5;
           
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

        private void CmbFirmante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                N.IdFirmante = int.Parse(CmbFirmante.SelectedValue.ToString());
                DataTable Tabla = N.TraerCargo();
                TxtCargo.Text = Tabla.Rows[0]["Cargo"].ToString();
            }
            catch
            {
                
            }
            
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (_nuevo==true && _editar==false)
            {
                ActivarControlDatos(gbDatos, false);
                LimpiarControl(gbDatos);
                BtnActualizar.Text = "Registros";
                ActivarButton(true);
                _nuevo = false;
                _editar = false;
                
            }
            else if(_editar==true)
            {
                ActivarControlDatos(gbDatos, false);
                LimpiarControl(gbDatos);
                BtnActualizar.Text = "Registros";
                ActivarButton(true);
                BtnAgregar.Text = "Agregar Defuncion";
                _editar = false;
                _nuevo = false;

            }
            else
            {
                using (BuscarDefuncionA Buscar = new BuscarDefuncionA())
                {
                    if (Buscar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        
                    }
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_editar == false && _nuevo==false )
            {
                
                _nuevo = true;
                ActivarControlDatos(gbDatos, true);
                
                BtnActualizar.Text = "Cancelar";
                ActivarButton(false);
                LimpiarControl(gbDatos);
                CargarNota();
                ActivarBoton(false);
                TxtLibro.Focus();


            }
            else if (_editar == true)
            {
                _editar = false;
                LimpiarControl(gbDatos);
                BtnActualizar.Text = "Cancelar";
                CargarNota();
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (_editar == false && _nuevo==true)
            {
                try
                {
                    String No_Defuncion = TxtCodigo.Text;
                    N.No_Defuncion = No_Defuncion;
                    N.Libro = TxtLibro.Text;
                    N.Folio = TxtFolio.Text;
                    N.Numero = TxtNumero.Text;
                    N.Nombre = TxtNombreDifunto.Text;
                    N.Fecha_Sepelio = TxtFechaSepelio.Text;
                    N.Ciudad_Origen = TxtOrigen.Text;
                    N.Edad = TxtEdad.Text;
                    
                    N.Padres = TxtPadres.Text;
                    N.Estado_Civil = TxtEstadoCivil.Text;
                    N.Ocacion_Muerte = TxtOcacion.Text;
                    N.NotaMarginal = TxtNota.Text;
                    N.Doy_Fe = CmbDoyFe.Text;
                    N.Firmante = int.Parse(CmbFirmante.SelectedValue.ToString());

                    string msj = "";
                    msj = N.InsertarDefuncion();

                    if (msj != "")
                    {
                        if ("Ya registraste esta defuncion" == msj)
                        {
                            MessageBox.Show(msj);
                        }
                        else
                        {
                            MessageBox.Show(msj);
                            LimpiarControl(gbDatos);
                            ActivarControlDatos(gbDatos, false);
                            ActivarButton(true);
                            _nuevo = false;
                            _editar = false;
                            ActivarBoton(true);
                            BtnActualizar.Text = "Editar";
                        }

                    }

                }
                catch
                {
                    MessageBox.Show("Verifica los campos");
                }

            }
            else if (_editar == true && _nuevo==false)
            {

                String No_Defuncion = TxtCodigo.Text;

                if (No_Defuncion != "")
                {
                    N.No_Defuncion = No_Defuncion;



                    N.Nombre = TxtNombreDifunto.Text;
                    N.Fecha_Sepelio = TxtFechaSepelio.Text;
                    N.Ciudad_Origen = TxtOrigen.Text;
                    N.Edad = TxtEdad.Text;
                    
                    N.Padres = TxtPadres.Text;
                    N.Estado_Civil = TxtEstadoCivil.Text;
                    N.Ocacion_Muerte = TxtOcacion.Text;
                    N.NotaMarginal = TxtNota.Text;
                    N.Doy_Fe = CmbDoyFe.Text;
                    N.Firmante = int.Parse(CmbFirmante.SelectedValue.ToString());

                    string msj = "";
                    msj = N.EditarDefuncion();
                    MessageBox.Show(msj);
                    if (msj != "")
                    {

                        LimpiarControl(gbDatos);
                        ActivarControlDatos(gbDatos, false);
                        _editar = false;
                        BtnAgregar.Text = "Agregar Defuncion";
                        CargarNota();
                        ActivarBoton(true);
                    }
                }
                   
            }
            else
            {

            }

        }

        private void TxtLibro_TextChanged_1(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtLibro.MaxLength = 5;
        }

        private void TxtFolio_TextChanged_1(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtLibro.MaxLength = 5;
        }

        private void TxtNumero_TextChanged_1(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtLibro.MaxLength = 5;
        }

        private void CmbFirmante_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            try
            {
                N.IdFirmante = int.Parse(CmbFirmante.SelectedValue.ToString());
                DataTable Tabla = N.TraerCargo();
                TxtCargo.Text = Tabla.Rows[0]["Cargo"].ToString();
            }
            catch
            {

            }

        }
    }
}
