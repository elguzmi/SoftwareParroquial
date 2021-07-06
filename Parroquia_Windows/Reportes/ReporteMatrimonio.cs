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
    public partial class ReporteMatrimonio : Form
    {
        ReporteMatrimonio_N Report = new ReporteMatrimonio_N();
        string codigo_partida {get; set;}
        public ReporteMatrimonio(string codigo)
        {
            InitializeComponent();
            codigo_partida = codigo;
            CargarDatos();
            
            
        }

        private void ReporteMatrimonio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }


        public void CargarDatos()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Parroquia_Windows.ReporteMatrimonio.rdlc";
            ReportDataSource rds1 = new ReportDataSource("Matrimonio", Report.Listar(codigo_partida));
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
    }
}
