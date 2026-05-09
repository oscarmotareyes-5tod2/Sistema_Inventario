using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Rol
    {
        CD_Rol datos = new CD_Rol();

        public void Guardar(E_Rol rol)
        {
            if (string.IsNullOrWhiteSpace(rol.Nombre_Rol))
                throw new Exception("El nombre del rol es obligatorio");

            datos.Insertar(rol);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(E_Rol rol)
        {
            datos.Actualizar(rol);
        }

        public void Eliminar(int id)
        {
            datos.Eliminar(id);
        }
    }
}
