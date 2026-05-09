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
    public class CD_Cliente
    {
        SqlConnection cn = Conexion.ObtenerConexion();


        public void Insertar(E_Cliente c)
        {
            SqlCommand cmd = new SqlCommand("Sp_InsertarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
            cmd.Parameters.AddWithValue("@Correo", c.Correo);
            cmd.Parameters.AddWithValue("@Direccion", c.Direccion);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }


        public DataTable Listar()
        {
            SqlDataAdapter da = new SqlDataAdapter("Sp_ListarClientes", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public void Actualizar(E_Cliente c)
        {
            SqlCommand cmd = new SqlCommand("SP_ActualizarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_cliente", c.Id_cliente);
            cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", c.Telefono);
            cmd.Parameters.AddWithValue("@Correo", c.Correo);
            cmd.Parameters.AddWithValue("@Direccion", c.Direccion);


            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }


        public void Eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("Sp_EliminarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id_Cliente", id);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
