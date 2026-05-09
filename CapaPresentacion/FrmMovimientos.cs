using CapaEntidades;
using CapaNegocio;
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
    public partial class FrmMovimientos : Form
    {
        public FrmMovimientos()
        {
            InitializeComponent();
        }
        CN_Movimiento mov = new CN_Movimiento();

        private void FrmMovimientos_Load(object sender, EventArgs e)
        {
            dgvMovis.DataSource =mov.Listar();
            dgvMovis.Columns[0].Visible = false;
        }


        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvMovis.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un movimiento");
                return;
            }

            int idMovimiento = Convert.ToInt32(
                dgvMovis.CurrentRow.Cells["Id_Movimiento"].Value
            );

            FrmReporte reporte = new FrmReporte(idMovimiento);
            reporte.ShowDialog();
        }
    }
}
