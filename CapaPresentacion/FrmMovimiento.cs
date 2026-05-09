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
    public partial class FrmMovimiento : Form
    {
        public FrmMovimiento()
        {
            InitializeComponent();
        }
        BindingList<E_Detalle_M> carrito = new BindingList<E_Detalle_M>();
        private void LProveedor_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            cmbTipo.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            txtCantidad.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CN_Movimiento movimiento = new CN_Movimiento();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id_Producto", typeof(int));
            dt.Columns.Add("Cantidad", typeof(int));

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells["Id_Producto"].Value != null)
                {
                    dt.Rows.Add(
                        Convert.ToInt32(row.Cells["Id_Producto"].Value),
                        Convert.ToInt32(row.Cells["Cantidad"].Value)
                    );
                }
            }

            E_Movimiento mov = new E_Movimiento()
            {
                Tipo_Movimiento = cmbTipo.Text,
                Fecha = DateTime.Now,
                Id_Usuario = Sesion.IdUsuario
            };

            try
            {
                int idMovimiento = movimiento.Guardar(mov, dt);

                MessageBox.Show("Movimiento guardado correctamente");

                
                FrmReporte frm = new FrmReporte(idMovimiento);
                frm.ShowDialog();

                LimpiarCampos();
                dgvDetalle.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmAdmin form = new FrmAdmin();
            form.ShowDialog();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            carrito.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            E_Detalle_M detalle = new E_Detalle_M()
            {
                Id_Producto = Convert.ToInt32(cmbProducto.SelectedValue),
                Producto = cmbProducto.Text,
                Cantidad = int.Parse(txtCantidad.Text)
            };

            carrito.Add(detalle);
            cmbProducto.SelectedIndex = -1;
            txtCantidad.Text = "1";
        }

        private void FrmMovimiento_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Entrada");
            cmbTipo.Items.Add("Salida");
            txtCantidad.Text = "0";
            CargarProductos();
            CargarProveedores();
            CargarUsuarioActual();
            CargarClientes();
            dgvDetalle.DataSource = carrito;
            dgvDetalle.Columns["Id_Detalle"].Visible = false;
            dgvDetalle.Columns["Id_Movimiento"].Visible = false;
            dgvDetalle.Columns["Id_Producto"].Visible = false;
        }

        private void CargarProductos()
        {
            CN_Producto prod = new CN_Producto();
            cmbProducto.DataSource = prod.Listar();
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id_Producto";
        }
        private void CargarClientes()
        {
            CN_Cliente cli = new CN_Cliente();
            cmbProveedor.DataSource = cli.Listar();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id_Cliente";
        }

        private void CargarProveedores()
        {
            CN_Proveedor prov = new CN_Proveedor();
            cmbProveedor.DataSource = prov.Listar();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id_Proveedor";
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

            txtNo.Text=Sesion.IdUsuario.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem.ToString() == "Entrada")
            {
                CN_Proveedor prov = new CN_Proveedor();
                LProveedor.Text="Proveedor";
                cmbProveedor.Visible = true;
                cmbProveedor.DataSource = prov.Listar();
            }
            else
            {
                CN_Cliente cli = new CN_Cliente();
                LProveedor.Text = "Cliente";
                cmbProveedor.DataSource= cli.Listar();
            }
        }
    }
}
