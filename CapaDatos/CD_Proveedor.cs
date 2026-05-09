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
    public class CD_Proveedor
    {
        SqlConnection cn = Conexion.ObtenerConexion();

        
        public void Insertar(E_Proveedor p)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarProveedor", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
            cmd.Parameters.AddWithValue("@Gmail", p.Gmail);
            cmd.Parameters.AddWithValue("@Direccion", p.Direccion);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        
        public DataTable Listar()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_ListarProveedores", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        public void Actualizar(E_Proveedor p)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarProveedor", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Proveedor", p.Id_Proveedor);
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
            cmd.Parameters.AddWithValue("@Gmail", p.Gmail);
            cmd.Parameters.AddWithValue("@Direccion", p.Direccion);
            

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        
        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarProveedor", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Proveedor", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
