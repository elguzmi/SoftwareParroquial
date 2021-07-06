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
    public partial class Modulo_ConfirmacionA : Form
    {
        Confirmaciones_N N = new Confirmaciones_N();
        bool _editar = false;
        bool _Nuevo = false;
         
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

        public Modulo_ConfirmacionA()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            CargarDatos();
            CargarNota();
            ActivarBoton(true);
        }

        private void Modulo_Confirmacion_Load(object sender, EventArgs e)
        {

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
        

        private void CargarDatos()
        {
            DataTable dt = N.ListadoMinistros(); // estamos llenando el data table con el metodo listado
            CmbFirmante.DataSource = dt;
            CmbFirmante.DisplayMember = "Nombre_Firmante";
            CmbFirmante.ValueMember = "Id_Firmante";
            ActivarControlDatos(GbDatos, false);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormPrincipalA ir = new FormPrincipalA();
            this.Hide();
            ir.Show();
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
            TxtFolio.MaxLength = 5;
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtNumero.MaxLength = 5;
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
                N.Codigo_Partida =CmbFirmante.SelectedValue.ToString();
                DataTable Tabla = N.TraerCargo();
                TxtCargo.Text = Tabla.Rows[0]["Cargo"].ToString();
            }
            catch
            {

            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (_Nuevo == true && _editar==false)
            {
                try {
                    string CodigoPartida = TxtCodigo.Text;
                    N.Codigo_Partida = CodigoPartida;
                    N.Libro = TxtLibro.Text;
                    N.Folio = TxtFolio.Text;
                    N.Numero =TxtNumero.Text;
                    N.Fecha_Confirmacion = TxtFecha_Confirmacion.Text;
                    N.Nombre_Confirmado = TxtNombre.Text;
                    N.Lugar_Nacimiento = TxtLugarNacimiento.Text;
                    N.Fecha_Nacimiento = TxtFechaNacimiento.Text;
                    N.Padres = TxtPadres.Text;
                    N.Parroquia_Bautismo = TxtParroquiaB.Text;
                    N.Diocesis = TxtDiocesis.Text;
                    N.Fecha_Bautismo = TxtFechaBautismo.Text;
                    N.LibroB = TxtLibroB.Text;
                    N.FolioB = TxtFolioB.Text;
                    N.NumeroB = TxtNumeroB.Text;
                    N.Padrinos = TxtPadrinos.Text;
                    N.Ministro = CmbMinistro.Text;
                    N.Doy_Fe = CmbDoyFe.Text;
                    N.Notas = TxtNota.Text;
                    N.Firmante = int.Parse(CmbFirmante.SelectedValue.ToString());

                    string msj = "";
                    msj = N.InsertarConfirmacion();
                    if (msj != "")
                    {
                        if (msj == "Ya registraste esta Confirmacion")
                        {
                            MessageBox.Show(msj);
                        }
                        else
                        {
                            MessageBox.Show(msj);
                            LimpiarControl(GbDatos);
                            CargarNota();
                            ActivarControlDatos(GbDatos, false);
                            _Nuevo = false;
                            BtnActualizar.Text = "Editar";

                            ActivarBoton(true);
                        }
                    }
                } 
                catch{

                    MessageBox.Show("Verifica los datos");

                }  
            }
            else if(_editar== true)
            {
                try
                {
                    string CodigoPartida = TxtCodigo.Text;
                    TxtCodigo.Text = CodigoPartida;
                    N.Codigo_Partida = CodigoPartida;
                    N.Fecha_Confirmacion = TxtFecha_Confirmacion.Text;
                    N.Nombre_Confirmado = TxtNombre.Text;
                    N.Lugar_Nacimiento = TxtLugarNacimiento.Text;
                    N.Fecha_Nacimiento = TxtFechaNacimiento.Text;
                    N.Padres = TxtPadres.Text;
                    N.Parroquia_Bautismo = TxtParroquiaB.Text;
                    N.Diocesis = TxtDiocesis.Text;
                    N.Fecha_Bautismo = TxtFechaBautismo.Text;
                    N.LibroB = TxtLibroB.Text;
                    N.FolioB = TxtFolioB.Text;
                    N.NumeroB =TxtNumeroB.Text;
                    N.Padrinos = TxtPadrinos.Text;
                    N.Ministro = CmbMinistro.Text;
                    N.Doy_Fe = CmbDoyFe.Text;
                    N.Notas = TxtNota.Text;
                    N.Firmante = int.Parse(CmbFirmante.SelectedValue.ToString());

                    string msj = "";
                    msj = N.EditarConfirmacion();
                    if (msj != "")
                    {
                        MessageBox.Show(msj);
                        ActivarControlDatos(GbDatos,false);
                        LimpiarControl(GbDatos);
                        
                        _editar = false;
                        _Nuevo = false;
                        BtnActualizar.Text = "Editar";
                        BtnNuevo.Enabled = true;
                        BtnAgregar.Text = "Agregar Confirmacion";
                        ActivarBoton(true);
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
            if(_Nuevo == true && _editar == false)
            {
                LimpiarControl(GbDatos);
                _Nuevo = false;
                _editar = false;
                ActivarControlDatos(GbDatos, false);
                CargarNota();
                ActivarBoton(true);
                BtnActualizar.Text = "Editar";
            }

            else if(_editar== true)
            {
                LimpiarControl(GbDatos);
                ActivarControlDatos(GbDatos, false);
                _Nuevo = false;
                _editar = false;
               
                BtnActualizar.Text = "Editar";
                ActivarBoton(true);
            }
            else
            {
                 
                using (RegistrosConfirmacionA Buscar = new RegistrosConfirmacionA())
                {
                    if (Buscar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        
                    }
                }
            } 
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if(_Nuevo == false)
            {
                ActivarControlDatos(GbDatos, true);
                
                _editar = false;
                _Nuevo = true;
                BtnActualizar.Text = "Cancelar";
                ActivarBoton(false);
                CargarNota();
                TxtLibro.Focus();
            }
           


        }

        private void TxtLibroB_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TxtFolioB_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtNumeroB_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtLibroB_TextChanged(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtLibro.MaxLength = 5;
        }

        private void TxtFolioB_TextChanged(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtFolio.MaxLength = 5;
        }

        private void TxtNumeroB_TextChanged(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtNumero.MaxLength = 5;
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
            TxtFolio.MaxLength = 5;
        }

        private void TxtNumero_TextChanged_1(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtNumero.MaxLength = 5;
        }

        private void CmbFirmante_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                N.Firmante = int.Parse(CmbFirmante.SelectedValue.ToString());
                DataTable Tabla = N.TraerCargo();
                TxtCargo.Text = Tabla.Rows[0]["Cargo"].ToString();
            }
            catch
            {

            }
        }
    }
}
