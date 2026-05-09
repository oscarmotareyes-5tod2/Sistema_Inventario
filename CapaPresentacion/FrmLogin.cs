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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        int intentos = 0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            CN_Login user = new CN_Login();
            

            DataTable dt = user.Entrar(txtUsuario.Text, txtContrasena.Text);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0]["Nombre"].ToString());

             
                Sesion.IdUsuario = Convert.ToInt32(dt.Rows[0]["Id_Usuario"]);
                Sesion.Nombre = dt.Rows[0]["Nombre"].ToString();
                Sesion.Rol = dt.Rows[0]["Nombre_Rol"].ToString();

               
                FrmAdmin menu = new FrmAdmin();
                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

            

            if (dt.Rows.Count == 0)
            {
                intentos++;

                if (intentos >= 3)
                {
                    MessageBox.Show("Demasiados intentos");
                    Application.Exit();
                }
            }
        }
    }
}
