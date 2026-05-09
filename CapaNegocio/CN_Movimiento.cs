using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Movimiento
    {
        CD_Movimiento datos = new CD_Movimiento();

        public int Guardar(E_Movimiento mov, DataTable detalles)
        {
           return datos.Guardar(mov, detalles);
        }

        public DataTable Listar()
        {
            return datos.Listar();
        }

        public DataTable Reporte(int id)
        {
            return datos.Reporte(id);
        }
    }
}
