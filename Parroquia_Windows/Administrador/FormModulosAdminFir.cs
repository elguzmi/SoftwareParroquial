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
    public partial class FormModulosAdminFir : Form
    {
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
        public FormModulosAdminFir()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void FormModulosAdminFir_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnModuloFirmantes_Click(object sender, EventArgs e)
        {
            FormFirmantes GFirmantes = new FormFirmantes();
            this.Hide();
            GFirmantes.Show();
        }

        private void BtnAdminUsuarios_Click(object sender, EventArgs e)
        {
            FormAdminUsuarios Admin = new FormAdminUsuarios();
            this.Hide();
            Admin.Show();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            FormPrincipal main = new FormPrincipal();
            main.Show();
            this.Hide();
        }
    }
}
