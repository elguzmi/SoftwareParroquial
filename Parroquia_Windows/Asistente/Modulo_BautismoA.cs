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
using System.Data;

namespace Parroquia_Windows
{
    public partial class Modulo_BautismoA : Form
    {

        List<Bautismo_E> lista = null;
        Bautismo_N N = new Bautismo_N();
        Bautismo_E e;
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
        public Modulo_BautismoA()
        {
            InitializeComponent();
            CargarDatos();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
            ActivarCampos(false);

            CargarcmbDoyfe();
            CargarcmbFirmantes();
            CargarNota();
            ActivarBoton(true);
        }

        private void CargarDatos()
        {
            
            TxtCargo.Enabled = false;
            
        }

        private void CargarNota()
        {
            TxtNota.Text = "SIN NOTAS MARGINALES HASTA LA FECHA";
        }

        private void ActivarBoton(bool estado)
        {
            BtnNuevo.Enabled = estado;
            BtnAgregar.Enabled=! estado;
        }

        private void ActivarCampos( bool estado)
        {
            TxtLibro.Enabled = estado;
            TxtFolio.Enabled = estado;
            TxtNumero.Enabled = estado;
            TxtNombreNiño.Enabled = estado;
            CmbMinistro.Enabled = estado;
            TxtFechaBautismo.Enabled = estado;
            TxtFechaNacimiento.Enabled = estado;
            Txt_LugarNac.Enabled = estado;
            TxtPadres.Enabled = estado;
            TxtAbuelosM.Enabled = estado;
            TxtAbuelosP.Enabled = estado;
            TxtPadrinos.Enabled = estado;
            CmbDoyFe.Enabled = estado;
            TxtNota.Enabled = estado;
            CmbFirma.Enabled = estado;
        }

        private void ActivarCamposEditar(bool estado)
        {
            TxtLibro.Enabled = !estado;
            TxtFolio.Enabled = !estado;
            TxtNumero.Enabled = !estado;
            TxtNombreNiño.Enabled = estado;
            CmbMinistro.Enabled = estado;
            TxtFechaBautismo.Enabled = estado;
            TxtFechaNacimiento.Enabled = estado;
            Txt_LugarNac.Enabled = estado;
            TxtPadres.Enabled = estado;
            TxtAbuelosM.Enabled = estado;
            TxtAbuelosP.Enabled = estado;
            TxtPadrinos.Enabled = estado;
            CmbDoyFe.Enabled = estado;
            TxtNota.Enabled = estado;
            CmbFirma.Enabled = estado;
        }

        private void Limpiar()
        {
            TxtCodigo.Clear();
            TxtCargo.Clear();
            TxtLibro.Clear(); 
            TxtFolio.Clear();
            TxtNumero.Clear();
            TxtNombreNiño.Clear();
            TxtFechaBautismo.Clear();
            TxtFechaNacimiento.Clear();
            Txt_LugarNac.Clear();
            TxtPadres.Clear();
            TxtAbuelosM.Clear();
            TxtAbuelosP.Clear();
            TxtPadrinos.Clear();
            TxtNota.Clear();
        }

        private void CargarcmbDoyfe()
        {
            DataTable data = N.ListadoMinistros(); // estamos llenando el data table con el metodo listado
            CmbDoyFe.DataSource = data;
            CmbDoyFe.DisplayMember = "Nombre_Firmante";
            CmbDoyFe.ValueMember = "Id_Firmante";
            
        }

        private void CargarcmbFirmantes()
        {
            DataTable dt = N.ListadoMinistros(); // estamos llenando el data table con el metodo listado
            CmbFirma.DataSource = dt;
            CmbFirma.DisplayMember = "Nombre_Firmante";
            CmbFirma.ValueMember = "Id_Firmante";
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

        private void ActivarButton(bool Estado)
        {
            BtnNuevo.Enabled = Estado;
            BtnAgregar.Enabled = !Estado;
            

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

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Modulo_Bautismo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

       

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (_nuevo == true){

                try {
                    string CodigoPartida = TxtCodigo.Text;

                    N.PartidaCodigo = CodigoPartida;
                    
                    if (CodigoPartida != "")
                    {
                        N.Libro = TxtLibro.Text;
                        N.Folio = TxtFolio.Text;
                        N.Numero = TxtNumero.Text;
                        N.Nombre = TxtNombreNiño.Text;

                        N.Ministro = CmbMinistro.Text;


                        N.FechaBautismo = TxtFechaBautismo.Text;
                        N.FechaNacimiento = TxtFechaNacimiento.Text;
                        N.LugarNacimiento = Txt_LugarNac.Text;
                        N.Padres = TxtPadres.Text;
                        N.AbuelosP = TxtAbuelosP.Text;
                        N.AbuelosM = TxtAbuelosM.Text;
                        N.Padrinos = TxtPadrinos.Text;
                        N.DoyFe = int.Parse(CmbDoyFe.SelectedValue.ToString());
                        N.NotaMarginal = TxtNota.Text.ToString();
                        N.Firmante = int.Parse(CmbFirma.SelectedValue.ToString());

                        String msj = "";
                        msj = N.InsertarBautismo();
                        if (msj != "")
                        {
                            if( msj == "Ya registraste este numero de partida")
                            {
                                MessageBox.Show(msj);

                            }
                            else
                            {
                                MessageBox.Show(msj);
                                Limpiar();
                                ActivarCampos(false);
                                BtnEditar.Text = "Editar";
                                CargarNota();
                                _nuevo = false;
                                ActivarBoton(true);
                            }
                        }
                    }
                    
                } 
                catch
                {
                    MessageBox.Show("Verifica los datos");
                }
                

            }else if (_editar== true)
            {

                //Para editar solo envio el codigo de partida
                string CodigoPartida = TxtCodigo.Text;

                N.PartidaCodigo = CodigoPartida;
               
                N.Nombre = TxtNombreNiño.Text;
                N.Ministro = CmbMinistro.Text;
                N.FechaBautismo = TxtFechaBautismo.Text;
                N.FechaNacimiento = TxtFechaNacimiento.Text;
                N.LugarNacimiento = Txt_LugarNac.Text;
                N.Padres = TxtPadres.Text;
                N.AbuelosP = TxtAbuelosP.Text;
                N.AbuelosM = TxtAbuelosM.Text;
                N.Padrinos = TxtPadrinos.Text;
                N.DoyFe = int.Parse(CmbDoyFe.SelectedValue.ToString());
                N.NotaMarginal = TxtNota.Text.ToString();
                N.Firmante = int.Parse(CmbFirma.SelectedValue.ToString());

                String msj = "";
                msj = N.EditarBautismo();
                if (msj != "")
                {
                    MessageBox.Show(msj);
                    Limpiar();
                    ActivarCampos(false);
                    BtnEditar.Text = "Editar";
                    BtnNuevo.Enabled = true;
                    _editar = false;
                    CargarNota();
                    ActivarBoton(true);
                }

            }
        }

        private void TxtPadrinos_TextChanged(object sender, EventArgs e)
        {

        }



        //Solo acepte numeros libro
        private void TxtLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }


        //Solo acepte numeros folio
        private void TxtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        //Solo acepte numeros Numero
        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            if(_nuevo == true)
            {

                ActivarCampos(true);
                BtnEditar.Text = "Cancelar";
                ActivarBoton(false);
                TxtLibro.Focus();
                
            }
           


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {


           
                using (BuscarBautismo Buscar = new BuscarBautismo())
                {
                    if(Buscar.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                    {                       
                        
                    }
                }
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            


        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            string CodigoPartida = TxtCodigo.Text;
            Reportes.ReporteBautismo report = new Reportes.ReporteBautismo(CodigoPartida);
            report.Show();

        }

        private void CmbMinistro_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void CmbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int Id = int.Parse(CmbFirma.SelectedValue.ToString());
            
            try
            {
                N.IdFirmante = int.Parse(CmbFirma.SelectedValue.ToString());
                DataTable Tabla = N.TraerCargo();
                TxtCargo.Text = Tabla.Rows[0]["Cargo"].ToString();
            }
            catch
            {
                
            }
            

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal();
            principal.Show();
            this.Hide();
        }


        #region cambios cuando se modifique el libro folio o numero
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
        #endregion
    }
}
