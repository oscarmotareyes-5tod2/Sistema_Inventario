using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria dal = new CD_Categoria ();

        public List<E_Categoria> Listar()
        {
            return dal.Listar();
        }

        public void Guardar(E_Categoria categoria)
        {
            if (categoria.Id_Categoria == 0)
                dal.Insertar(categoria);
            else
                dal.Actualizar(categoria);
        }
        public void Actualizar(E_Categoria categoria)
        {
            dal.Actualizar(categoria);
        }

        public void Eliminar(int id)
        {
            dal.Eliminar(id);
        }
    }
}
