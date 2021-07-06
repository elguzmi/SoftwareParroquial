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
    public partial class FormPrincipalA : Form
    {
       
        public FormPrincipalA()
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
            
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo_BautismoA Bau = new Modulo_BautismoA();
            Bau.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void BtnMatrimonio_Click(object sender, EventArgs e)
        {
            Modulo_MatrimonioA Matri = new Modulo_MatrimonioA();
            Matri.Show();
            this.Hide();
        }

        private void BtnConfirmacion_Click(object sender, EventArgs e)
        {
            Modulo_ConfirmacionA confi = new Modulo_ConfirmacionA();
            confi.Show();
            this.Hide();
        }

        private void BtnDefuncion_Click(object sender, EventArgs e)
        {
            Modulo_DefuncionA defuncion = new Modulo_DefuncionA();
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
