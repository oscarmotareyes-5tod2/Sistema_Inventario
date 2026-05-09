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
using static CapaEntidades.E_Login;

namespace CapaPresentacion
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        CN_Producto pro = new CN_Producto();

        private void CargarCategorias()
        {
            CN_Categoria cat = new CN_Categoria();
            cmbCategoria.DataSource = cat.Listar();
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id_Categoria";
        }

        private void CargarProveedores()
        {
            CN_Proveedor prov = new CN_Proveedor();
            cmbProveedor.DataSource = prov.Listar();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id_Proveedor";
        }

      private void Cargaru() 
        { 

        }
        private void CargarUsuarioActual()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id_Usuario");
            dt.Columns.Add("Nombre");

            dt.Rows.Add(Sesion.IdUsuario, Sesion.Nombre);


            cmbUsuario.DataSource = dt;
            cmbUsuario.DisplayMember = "Nombre";
            cmbUsuario.ValueMember = "Id_Usuario";
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
        }

        private void Listar()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = pro.Listar();
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarProveedores();
            Listar();
            CargarUsuarioActual();
            dgvProductos.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Columns[ "Id_Producto"].Visible = false;
            dgvProductos.Columns["Id_Categoria"].Visible = false;
            dgvProductos.Columns["Id_Proveedor"].Visible = false;
            dgvProductos.Columns["Modificado_Por"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtPrecio.Text) ||
               string.IsNullOrWhiteSpace(txtStock.Text) ||
               string.IsNullOrWhiteSpace(cmbCategoria.Text)||
               string.IsNullOrWhiteSpace(cmbProveedor.Text)||
               string.IsNullOrWhiteSpace(cmbUsuario.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error");
                return;
            }

            E_Producto p = new E_Producto()
            {
                Nombre = txtNombre.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                Id_Categoria = Convert.ToInt32(cmbCategoria.SelectedValue),
                Id_Proveedor = Convert.ToInt32(cmbProveedor.SelectedValue),
                Modificado_Por = Convert.ToInt32(cmbUsuario.SelectedValue),
            };

            pro.Guardar(p);

            Listar();
            Limpiar();

            MessageBox.Show("Producto guardado");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            E_Producto p = new E_Producto()
            {
                Id_Producto = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Stock = Convert.ToInt32(txtStock.Text),
                Id_Categoria = Convert.ToInt32(cmbCategoria.SelectedValue),
                Id_Proveedor = Convert.ToInt32(cmbProveedor.SelectedValue),
                Modificado_Por = Convert.ToInt32(cmbUsuario.SelectedValue),
            };

            pro.Actualizar(p);

            Listar();
            Limpiar();

            MessageBox.Show("Producto guardado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            pro.Eliminar(id);

            Listar();
            dgvProductos.Columns["Id_Producto"].Visible = false;
            Limpiar();

            MessageBox.Show("Producto eliminado");
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                txtId.Text = row.Cells["Id_Producto"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();
                cmbCategoria.SelectedValue = Convert.ToInt32(row.Cells["Id_Categoria"].Value);
                cmbProveedor.SelectedValue = Convert.ToInt32(row.Cells["Id_Proveedor"].Value);
                cmbUsuario.SelectedValue = Convert.ToInt32( row.Cells["Modificado_Por"].Value.ToString());
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmAdmin form = new FrmAdmin();
            form.ShowDialog();
            this.Hide();
        }
    }
}
