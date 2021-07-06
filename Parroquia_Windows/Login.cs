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
using System.Reflection;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

using CrystalDecisions;
using System.Data.SqlClient;

namespace Parroquia_Windows
{
    public partial class Login : Form
    {

        Login_N Objn = new Login_N();
        Login_E Obje = new Login_E();


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
        public Login()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
             
            
            Obje.usuario= (TxtUsuario.Text).Trim();   // pasamos los valores
            Obje.Pass = (TxtContraseña.Text).Trim();

            DataTable data = new DataTable();
            data = Objn.N_Login(Obje);

            if (data.Rows.Count > 0)
            {
                string  Id_Usuario = data.Rows[0][0].ToString();
                string Usuario = data.Rows[0][1].ToString();
                int Tipo = int.Parse(data.Rows[0][2].ToString());
                string Clave = data.Rows[0][3].ToString();

                if (Tipo == 1)
                {
                    
                    FormPrincipal Main = new FormPrincipal();
                    Main.Show();
                    this.Hide();
                }
                else if (Tipo == 2)
                {
                    
                    FormPrincipalA MainA = new FormPrincipalA();
                    MainA.Show();
                    this.Hide();
                }


            }
            else
            {
                MessageBox.Show("No existe el usuario");
            }

        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BtnIngresar.PerformClick();
            }
        }

        private void Btnprueba_Click(object sender, EventArgs e)
        {
           


        }
    }
}
