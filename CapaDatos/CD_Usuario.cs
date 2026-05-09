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
    public class CD_Usuario
    {
        SqlConnection cn = Conexion.ObtenerConexion();

        
        public void Insertar(E_Usuario u)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
            cmd.Parameters.AddWithValue("@Username", u.Username);
            cmd.Parameters.AddWithValue("@password", u.password);
            cmd.Parameters.AddWithValue("@Id_Rol", u.Id_Rol);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

      
        public DataTable Listar()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_ListarUsuarios", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        public void Actualizar(E_Usuario u)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Usuario", u.Id_Usuario);
            cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
            cmd.Parameters.AddWithValue("@Username", u.Username);
            cmd.Parameters.AddWithValue("@password", u.password);
            cmd.Parameters.AddWithValue("@Id_Rol", u.Id_Rol);


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

       
        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Usuario", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
