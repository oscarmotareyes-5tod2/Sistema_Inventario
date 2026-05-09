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
    public class CD_Movimiento
    {
        public int Guardar(E_Movimiento mov, DataTable detalles)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_MovimientoCompleto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Tipo_Movimiento", mov.Tipo_Movimiento);
                cmd.Parameters.AddWithValue("@Fecha", mov.Fecha);
                cmd.Parameters.AddWithValue("@Id_Usuario", mov.Id_Usuario);

                SqlParameter param = cmd.Parameters.AddWithValue("@Detalles", detalles);
                param.SqlDbType = SqlDbType.Structured;

                cn.Open();
                int idMovimiento = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();

                return idMovimiento;
            }
        }

    
        public DataTable Listar()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ListarMovimientos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public DataTable Reporte(int id)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ReporteMovimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Movimiento", id);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}
