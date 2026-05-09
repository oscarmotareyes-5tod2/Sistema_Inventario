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
    public class CN_Proveedor
    {
        CD_Proveedor datos = new CD_Proveedor();

        public void Guardar(E_Proveedor p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre es obligatorio");

            datos.Insertar(p);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(E_Proveedor p)
        {
            datos.Actualizar(p);
        }

        public void Eliminar(int id)
        {
            datos.Eliminar(id);
        }
    }
}
