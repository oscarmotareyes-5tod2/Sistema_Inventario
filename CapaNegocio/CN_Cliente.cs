using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        CD_Cliente datos = new CD_Cliente();

        public void Guardar(E_Cliente c)
        {
            if (string.IsNullOrWhiteSpace(c.Nombre))
                throw new Exception("El nombre es obligatorio");

            datos.Insertar(c);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(E_Cliente c)
        {
            datos.Actualizar(c);
        }

        public void Eliminar(int id)
        {
            datos.Eliminar(id);
        }
    }
}
