using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCT_RH.CONTROLADORES
{
    class UsuarioController
    {
        static int intTuplasManipuladas = 0;

        /// <summary>
        /// Método para registrar usuarios nuevos al sistema.
        /// </summary>
        /// <param name="u"></param>
      /**   public static void RegistrarUsuario(Modelos.Usuario u)
        {
            String query = "INSERT INTO USUARIO VALUES (@idUsuario, @usuario, @contraseña, @rol)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, ConexionController.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", u.getIdUsuario());
                    cmd.Parameters.AddWithValue("@usuario", u.getUsuario());
                    cmd.Parameters.AddWithValue("@contraseña", u.getPassword());
                    cmd.Parameters.AddWithValue("@rol", u.getRol());
                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado < intTuplasManipuladas)
                        MessageBox.Show("Error al insertar en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); // Operación no exitosa
                    else
                        MessageBox.Show("Usuario agregado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information); // Operación exitosa
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); // Recuperamos el error que haya lanzado SQL y lo mostramos en pantalla
            }
            finally
            {
                ConexionController.Desconectar();
            }
        }

      
    }
}
}
