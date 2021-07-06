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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Parroquia_Windows.Reportes
{
    public partial class ReporteBautismo : Form
    {
        public string codigo_partida { get; set; }

        ReporteBautismo_N Report = new ReporteBautismo_N();
        public ReporteBautismo(string codigo)
        {
            InitializeComponent();
            codigo_partida = codigo;
            
            CargarDatos();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

        public void CargarDatos()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Parroquia_Windows.ReporteBautismo.rdlc";
            ReportDataSource rds1 = new ReportDataSource("Data_Bautismo", Report.Listar(codigo_partida));
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
    }
}
