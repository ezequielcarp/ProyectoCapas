using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonaDAL
    {
        public static int AgregarPersona(Persona persona)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "INSERT INTO PERSONA (nombre, edad, celular) VALUES(@nombre, @edad, @celular)";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@nombre", persona.nombre);
                comando.Parameters.AddWithValue("@edad", persona.edad);
                comando.Parameters.AddWithValue("@celular", persona.celular);

                retorna = comando.ExecuteNonQuery();

            }

            return retorna;
        }


        public static List<Persona> PresentarRegistro()
        {
            List<Persona> Lista = new List<Persona>();

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "SELECT *FROM PERSONA";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();
                
                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.id = reader.GetInt32(0);
                    persona.nombre = reader.GetString(1);
                    persona.edad = reader.GetInt32(2);
                    persona.celular = reader.GetString(3);
                    Lista.Add(persona);
                }

                conexion.Close();
                return Lista;
            }


        }

    

    public static int ModificarPersona(Persona persona)
        {
            int result = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "UPDATE PERSONA SET nombre = @nombre, edad = @edad, celular = @celular WHERE id = @id";
                SqlCommand comando = new SqlCommand( query, conexion);


                comando.Parameters.AddWithValue("@nombre", persona.nombre);
                comando.Parameters.AddWithValue("@edad", persona.edad);
                comando.Parameters.AddWithValue("@celular", persona.celular);
                comando.Parameters.AddWithValue("@id", persona.id);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }

        public static int EliminarPersona(int id)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "DELETE FROM PERSONA WHERE id = @id";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@id", id);
                retorna = comando.ExecuteNonQuery();

            }

            return retorna;
        }

    }
}
