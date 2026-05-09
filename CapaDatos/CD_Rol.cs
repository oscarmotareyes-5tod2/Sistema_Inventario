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
    public class CD_Rol
    {
        SqlConnection cn =Conexion.ObtenerConexion();

        
        public void Insertar(E_Rol rol)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarRol", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre_Rol", rol.Nombre_Rol);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        
        public DataTable Listar()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_ListarRoles", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        public void Actualizar(E_Rol rol)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarRol", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Rol", rol.Id_Rol);
            cmd.Parameters.AddWithValue("@Nombre_Rol", rol.Nombre_Rol);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        
        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarRol", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Rol", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
