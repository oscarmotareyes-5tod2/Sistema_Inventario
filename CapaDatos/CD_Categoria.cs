using CapaDatos;
using CapaEntidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<E_Categoria> Listar()
        {
            List<E_Categoria> lista = new List<E_Categoria>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarCategorias", cn);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new E_Categoria
                    {
                        Id_Categoria = (int)dr["Id_Categoria"],
                        Nombre = dr["Nombre"].ToString(),

                    });

                }
                return lista;
            }
        }

        public void Insertar(E_Categoria categoria)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);


                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(E_Categoria categoria)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Categoria", categoria.Id_Categoria);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);


                cn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public void Eliminar(int id)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Categoria", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}    
