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
    public class CN_Producto
    {
        CD_Producto datos = new CD_Producto();

        public void Guardar(E_Producto p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("Nombre obligatorio");

            datos.Insertar(p);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public void Actualizar(E_Producto p)
        {
            datos.Actualizar(p);
        }

        public void Eliminar(int id)
        {
            datos.Eliminar(id);
        }
    }
}
