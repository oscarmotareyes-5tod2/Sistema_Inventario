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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmCategoria());
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmMovimiento());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmProductos());
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmProveedor());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmUsuario());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
            this.Hide();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            LUsuario.Text = Sesion.Nombre;
            LRol.Text = Sesion.Rol;
            AplicarPermisos();
            
        }
        private void AplicarPermisos()
        {
            string rol = Sesion.Rol;

            if (rol == "Administrador")
            {
                // Acceso total
            }
            else if (rol == "Consulta")
            {
                btnUsuario.Enabled = false;
                btnMovimiento.Enabled = false;
                btnCategoria.Enabled = false;
                btnProductos.Enabled = false;
                btnProveedor.Enabled = false;
                btnCliente.Enabled = false;
            }
            else if (rol == "Almacen")
            {
                btnUsuario.Enabled = false;
                btnCliente.Enabled = false;
            }
        }
        private void AbrirForm(Form formHijo)
        {
            PContenedor.Controls.Clear(); 

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            PContenedor.Controls.Add(formHijo);
            PContenedor.Tag = formHijo;

            formHijo.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmCliente());
        }

        private void btnMovis_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmMovimientos());
        }
    }
}
