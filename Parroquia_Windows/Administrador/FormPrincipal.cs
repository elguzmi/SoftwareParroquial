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

namespace Parroquia_Windows
{
    public partial class FormPrincipal : Form
    {
        
        public FormPrincipal()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
           // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo_Bautismo bautismo = new Modulo_Bautismo();
            bautismo.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {
            FormModulosAdminFir Configuracion = new FormModulosAdminFir();
            Configuracion.Show();
            this.Hide();
        }

        private void BtnMatrimonio_Click(object sender, EventArgs e)
        {
            Modulo_Matrimonio matri = new Modulo_Matrimonio();
            matri.Show();
            this.Hide();
        }

        private void BtnConfirmacion_Click(object sender, EventArgs e)
        {
            Modulo_Confirmacion confir = new Modulo_Confirmacion();
            confir.Show();
            this.Hide();
        }

        private void BtnDefuncion_Click(object sender, EventArgs e)
        {
            Modulo_Defuncion defuncion = new Modulo_Defuncion();
            defuncion.Show();
            this.Hide();
        }

        private void BtnAcerca_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.Show();
        }
    }
}
