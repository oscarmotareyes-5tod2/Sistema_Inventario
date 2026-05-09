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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        CN_Usuario user = new CN_Usuario();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LContraseña_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Listar();
            dgvUsuario.Columns["Id_Usuario"].Visible = false;
            CargarRoles();
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void CargarRoles()
        {
            CN_Rol rol = new CN_Rol();

            cmbRol.DataSource = rol.Listar();
            cmbRol.DisplayMember = "Nombre_Rol";
            cmbRol.ValueMember = "Id_Rol";
        }

        private void Listar()
        {
            dgvUsuario.DataSource = null;
            dgvUsuario.DataSource = user.Listar();
        }
        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtUser.Clear();
            txtContraseña.Clear();
            cmbRol.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                cmbRol.SelectedValue == null)
    {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            E_Usuario u = new E_Usuario()
            {
                Nombre = txtNombre.Text,
                Username = txtUser.Text,
                password = txtContraseña.Text,
                Id_Rol = Convert.ToInt32(cmbRol.SelectedValue)
            };

            user.Guardar(u);
            Listar();
            Limpiar();
            MessageBox.Show("Usuario guardado correctamente");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            E_Usuario u = new E_Usuario()
            {
                Id_Usuario = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Username = txtUser.Text,
                password = txtContraseña.Text,
                Id_Rol = Convert.ToInt32(cmbRol.SelectedValue),
                
            };

            user.Actualizar(u);
            Listar();
            Limpiar();
            MessageBox.Show("Usuario actualizado correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);

            DialogResult r = MessageBox.Show("¿Eliminar este usuario?","Confirmar",
            MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                user.Eliminar(id);
                Listar();
                Limpiar();

                MessageBox.Show("Usuario eliminado");                
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuario.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id_Usuario"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtUser.Text = row.Cells["Username"].Value.ToString();
                txtContraseña.Text = row.Cells["Password"].Value.ToString();
                cmbRol.Text = row.Cells["Nombre_Rol"].Value.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
