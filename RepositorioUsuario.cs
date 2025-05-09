using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laboratorio3_gestion_tareas.ConexionDB;

namespace laboratorio3_gestion_tareas
{
    internal class RepositorioUsuario
    {
        private ConexionDB conexion = new ConexionDB();

        public void GuardarUsuario(Usuario usuario)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Usuarios (nombre_usuario, apellido_usuario, rol_usuario) VALUES (@nombre, @apellido, @rol)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", usuario.NombreUsuario);
                    cmd.Parameters.AddWithValue("@apellido", usuario.ApellidoUsuario);
                    cmd.Parameters.AddWithValue("@rol", usuario.ApellidoUsuario);
                 
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<Usuario> obtenerTodosLosUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT id_usuario, nombre_usuario, apellido_usuario FROM Usuarios";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                            NombreUsuario = reader["nombre_usuario"].ToString(),
                            ApellidoUsuario = reader["apellido_usuario"].ToString(),
                         
                        };

                        listaUsuarios.Add(usuario);
                    }
                }
            }

            return listaUsuarios;
        }


    }
}
