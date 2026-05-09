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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Listar();
            dgvCliente.Columns["Id_cliente"].Visible = false;
            dgvCliente.Columns[5].Visible= false;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        CN_Cliente cli = new CN_Cliente();

        private void Listar()
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = cli.Listar();
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

            E_Cliente c = new E_Cliente()
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtGmail.Text,
                Direccion = txtDireccion.Text
            };

            cli.Guardar(c);

            Listar();
            dgvCliente.Columns["Id_cliente"].Visible = false;
            dgvCliente.Columns[5].Visible = false;
            Limpiar();

            MessageBox.Show("Cliente guardado");
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

            E_Cliente c = new E_Cliente()
            {
                Id_cliente = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtGmail.Text,
                Direccion = txtDireccion.Text,

            };

            cli.Actualizar(c);

            Listar();
            dgvCliente.Columns["Id_cliente"].Visible = false;
            dgvCliente.Columns[5].Visible = false;
            Limpiar();

            MessageBox.Show("Cliente actualizado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            cli.Eliminar(id);

            Listar();
            Limpiar();

            MessageBox.Show("Cliente eliminado");
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCliente.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id_cliente"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtGmail.Text = row.Cells["Correo"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
            }
        }
    }
}
