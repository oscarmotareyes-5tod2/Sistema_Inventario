using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Producto
    {
        SqlConnection cn = Conexion.ObtenerConexion();

        public void Insertar(E_Producto p)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Precio", p.Precio);
            cmd.Parameters.AddWithValue("@Stock", p.Stock);
            cmd.Parameters.AddWithValue("@Id_Categoria", p.Id_Categoria);
            cmd.Parameters.AddWithValue("@Id_Proveedor", p.Id_Proveedor);
            cmd.Parameters.AddWithValue("@Modificado_Por", p.Modificado_Por);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable Listar()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarProductos", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Actualizar(E_Producto p)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Producto", p.Id_Producto);
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Precio", p.Precio);
            cmd.Parameters.AddWithValue("@Stock", p.Stock);
            cmd.Parameters.AddWithValue("@Id_Categoria", p.Id_Categoria);
            cmd.Parameters.AddWithValue("@Id_Proveedor", p.Id_Proveedor);
            
           

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Producto", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
