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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            Listar();
        }
        CN_Categoria cate = new CN_Categoria();

        private void Limpiar()
        {
            txtNombre.Clear();
        }

        private void Listar()
        {
            dgvCategoria.DataSource = cate.Listar();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la Categoria es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            return true;
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Listar();
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Columns["Id_Categoria"].Visible = false;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                E_Categoria c = new E_Categoria
                {
               
                    Nombre = txtNombre.Text,
                   
                };


                cate.Guardar(c);
                Listar();
                Limpiar();

                MessageBox.Show("Categoría guardada correctamente");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione una categoría para actualizar");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);

            E_Categoria categoria = new E_Categoria()
              {
                Id_Categoria = id,
                Nombre = txtNombre.Text,
                
              };
            cate.Actualizar(categoria);

            Listar();
            Limpiar();

            MessageBox.Show("Categoría actualizada correctamente");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione una categoría para eliminar");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);


            cate.Eliminar(id);

            Listar();
            Limpiar();

            MessageBox.Show("Categoría eliminada correctamente");
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                txtId.Text = dgvCategoria.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
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
