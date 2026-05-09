using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class FrmReporte : Form
    {
        private int _idMovimiento;
        public FrmReporte(int idmovimiento)
        {
            InitializeComponent();
            _idMovimiento = idmovimiento;
        }
        private void CargarReporte()
        {
            CN_Movimiento cd = new CN_Movimiento();
            DataTable dt = cd.Reporte(_idMovimiento);

            rvMovi.LocalReport.ReportPath = @"C:\Users\oscar\source\repos\Sistema_Inventario\CapaPresentacion\Reportes\Movimientos.rdlc";

            rvMovi.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DatosReporte", dt);
            rvMovi.LocalReport.DataSources.Add(rds);

            rvMovi.RefreshReport();
        }
        private void FrmReporte_Load(object sender, EventArgs e)
        {

            this.rvMovi.RefreshReport();
            CargarReporte();

        }


    }
}
