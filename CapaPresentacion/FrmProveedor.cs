using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
        }
        CN_Proveedor pro = new CN_Proveedor();
        private void Listar()
        {
            dgvProveedor.DataSource = null;
            dgvProveedor.DataSource = pro.Listar();
        }

        private bool EsEmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w+$");
        }
        private bool EsTelefonoValido(string telefono)
        {
            return Regex.IsMatch(telefono, @"^\+?[\d-]{7,15}$");
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtGmail.Clear();
            txtDireccion.Clear();
        }
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            Listar();
            dgvProveedor.Columns[0].Visible = false;
            dgvProveedor.Columns[5].Visible = false;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtGmail.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error");
                return;
            }

            if (!EsTelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("Teléfono no válido (7–15 dígitos).", "Error");
                return;
            }

            if (!EsEmailValido(txtGmail.Text))
            {
                MessageBox.Show("Email no válido.", "Error");
                return;
            }

            E_Proveedor p = new E_Proveedor()
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Gmail = txtGmail.Text,
                Direccion = txtDireccion.Text
            };

            pro.Guardar(p);

            Listar();
            Limpiar();

            MessageBox.Show("Proveedor guardado");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtGmail.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error");
                return;
            }

            if (!EsTelefonoValido(txtTelefono.Text))
            {
                MessageBox.Show("Teléfono no válido (7–15 dígitos).", "Error");
                return;
            }

            if (!EsEmailValido(txtGmail.Text))
            {
                MessageBox.Show("Email no válido.", "Error");
                return;
            }

            E_Proveedor p = new E_Proveedor()
            {
                Id_Proveedor = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Gmail = txtGmail.Text,
                Direccion = txtDireccion.Text,
                
            };

            pro.Actualizar(p);

            Listar();
            Limpiar();

            MessageBox.Show("Proveedor actualizado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            pro.Eliminar(id);

            Listar();
            Limpiar();

            MessageBox.Show("Proveedor eliminado");
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedor.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id_Proveedor"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtGmail.Text = row.Cells["Gmail"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
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
