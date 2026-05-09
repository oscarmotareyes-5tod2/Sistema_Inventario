using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; 
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Login
    {
        SqlConnection cn = Conexion.ObtenerConexion();
        public DataTable Entrar(string user, string pass)
        {
            SqlCommand cmd = new SqlCommand("sp_Login", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Username", user);
            cmd.Parameters.AddWithValue("@password", pass);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
