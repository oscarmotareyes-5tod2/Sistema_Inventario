using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        CD_Usuario datos = new CD_Usuario();

        public void Guardar(E_Usuario u)
        {
            if (string.IsNullOrWhiteSpace(u.Nombre) ||
                string.IsNullOrWhiteSpace(u.Username) ||
                string.IsNullOrWhiteSpace(u.password))
            {
                throw new Exception("Campos obligatorios");
            }

            datos.Insertar(u);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(E_Usuario u)
        {
            datos.Actualizar(u);
        }

        public void Eliminar(int id)
        {
            datos.Eliminar(id);
        }
    }
}
