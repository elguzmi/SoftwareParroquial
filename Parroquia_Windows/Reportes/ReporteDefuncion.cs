using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parroquia.Negocio;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Parroquia_Windows.Reportes
{
    public partial class ReporteDefuncion : Form
    {

        ReporteDefuncion_N Report = new ReporteDefuncion_N();
        string Codigo { get; set; }
        public ReporteDefuncion( string codigo)
        {
            InitializeComponent();
            Codigo = codigo;
            CargarDatos();
        }

        private void ReporteConfirmacion_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void CargarDatos()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Parroquia_Windows.ReporteDefuncion.rdlc";
            ReportDataSource rds1 = new ReportDataSource("Defuncion", Report.Listar(Codigo));
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
    }
}
