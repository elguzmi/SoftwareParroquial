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
    public partial class Modulo_Confirmacion : Form
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

        public Modulo_Confirmacion()
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
            FormPrincipal ir = new FormPrincipal();
            this.Hide();
            ir.Show();
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
                    String Codigo = TxtCodigo.Text;
                    N.Codigo_Partida = Codigo;
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
                            if (MessageBox.Show("Desea Imprimir el registro", "Imprimir registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                try
                                {
                                    Reportes.ReporteConfirmacion reporte = new Reportes.ReporteConfirmacion(TxtCodigo.Text);
                                    reporte.Show();
                                }
                                catch
                                {
                                    MessageBox.Show("No has seleccionado ningun registros");
                                }
                            }
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
                    String Codigo = TxtCodigo.Text;
                    N.Codigo_Partida = Codigo;
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
                        if (MessageBox.Show("Desea Imprimir el registro", "Imprimir registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                Reportes.ReporteConfirmacion reporte = new Reportes.ReporteConfirmacion(TxtCodigo.Text);
                                reporte.Show();
                            }
                            catch
                            {
                                MessageBox.Show("No has seleccionado ningun registros");
                            }
                        }
                        //ActivarControlDatos(GbDatos,false);
                        //LimpiarControl(GbDatos);
                        
                        _editar = true;
                        _Nuevo = false;
                        //BtnActualizar.Text = "Editar";
                        //BtnNuevo.Enabled = true;
                        //BtnAgregar.Text = "Agregar Confirmacion";
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
                 
                using (RegistrosConfirmacion Buscar = new RegistrosConfirmacion())
                {
                    if (Buscar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {

                            string CodigoPartida = Buscar.TxtPartida.Text;
                            string Nombre = Buscar.TxtNombre.Text;
                           // MessageBox.Show(CodigoPartida.ToString());
                            N.Codigo_Partida = CodigoPartida;


                            DataTable Tabla = N.TraerConfirmacion();

                            string libro= Tabla.Rows[0]["Libro"].ToString();
                            string folio = Tabla.Rows[0]["Folio"].ToString();
                            string numero= Tabla.Rows[0]["Numero"].ToString();
                            TxtCodigo.Text = libro + folio + numero;
                            TxtLibro.Text = libro;
                            TxtFolio.Text = folio;
                            TxtNumero.Text = numero;

                           

                            TxtFecha_Confirmacion.Text = Tabla.Rows[0]["Fecha_Confirmacion"].ToString();
                            TxtNombre.Text = Tabla.Rows[0]["Nombre_Confirmado"].ToString();

                            TxtLugarNacimiento.Text = Tabla.Rows[0]["Lugar_Nacimiento"].ToString();
                            TxtFechaNacimiento.Text = Tabla.Rows[0]["Fecha_Nacimiento"].ToString();
                            TxtPadres.Text = Tabla.Rows[0]["Nombre_Padres"].ToString();

                            TxtParroquiaB.Text = Tabla.Rows[0]["Parroquia_Bautizo"].ToString();
                            TxtDiocesis.Text = Tabla.Rows[0]["Diocesis"].ToString();

                            TxtFechaBautismo.Text = Tabla.Rows[0]["Fecha_Bautismo"].ToString();
                            TxtLibroB.Text = Tabla.Rows[0]["Libro_B"].ToString();
                            TxtFolioB.Text = Tabla.Rows[0]["Folio_B"].ToString();
                            TxtNumeroB.Text = Tabla.Rows[0]["Numero_B"].ToString();
                            TxtPadrinos.Text = Tabla.Rows[0]["Padrinos"].ToString();
                            CmbMinistro.Text = Tabla.Rows[0]["Ministro"].ToString();
                            
                            if (Tabla.Rows[0]["Doy_Fe"].ToString() == "")
                            {
                                CmbDoyFe.Text = "";
                            }
                            else
                            {
                                CmbDoyFe.Text = Tabla.Rows[0]["Doy_Fe"].ToString(); ;
                            }
                            TxtNota.Text = Tabla.Rows[0]["Notas_Correcciones"].ToString();
                            if (Tabla.Rows[0]["Firmante"].ToString() == "")
                            {
                                CmbFirmante.Text = "";
                            }
                            else
                            {
                                CmbFirmante.SelectedValue = int.Parse(Tabla.Rows[0]["Firmante"].ToString());
                            }
                            

                            _editar = true;
                            BtnAgregar.Text = "Guardar Cambios";
                            ActivarBoton(false);
                            BtnActualizar.Text = "Cancelar";
                            ActivarControlDatos(GbDatos, true);
                            TxtLibro.Enabled = false;
                            TxtFolio.Enabled = false;
                            TxtNumero.Enabled = false;
                            

                        }
                        catch
                        {
                            MessageBox.Show("No has seleccionado ningun registro");
                            ActivarBoton(true);
                        }
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

        private void lineShape11_Click(object sender, EventArgs e)
        {

        }

        private void GbDatos_Enter(object sender, EventArgs e)
        {

        }

        #region cambio en el texto de libro folio numero

        private void TxtLibro_TextChanged_2(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtLibro.MaxLength = 5;
        }

        private void TxtNumero_TextChanged_2(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtNumero.MaxLength = 5;
        }

        private void TxtFolio_TextChanged_2(object sender, EventArgs e)
        {
            string CodigoPartida = TxtLibro.Text + TxtFolio.Text + TxtNumero.Text;
            TxtCodigo.Text = CodigoPartida;
            TxtFolio.MaxLength = 5;
        }

        #endregion

        private void TxtNumeroB_TextChanged(object sender, EventArgs e)
        {
            TxtNumeroB.MaxLength = 5;
        }

        private void TxtLibroB_TextChanged(object sender, EventArgs e)
        {
            TxtLibroB.MaxLength = 5;
        }

        private void TxtFolioB_TextChanged(object sender, EventArgs e)
        {
            TxtFolioB.MaxLength = 5;
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Reportes.ReporteConfirmacion reporte = new Reportes.ReporteConfirmacion(TxtCodigo.Text);
                reporte.Show();
            }
            catch
            {
                MessageBox.Show("No has seleccionado ningun registros");
            }
        }
    }
}
