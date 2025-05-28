using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_C__backend.Models
{
    // Clase para manejar la base de datos de Sofas
    internal class SofasDB
    {
        // Cadena de conexión a la base de datos
        private string connectionString = "Data Source=MILAPTOPASUS\\SQLEXPRESS;Initial Catalog=EXDB003;" +
            "integrated security=true;";
        // Fución para obtener todos los sofas de la base de datos
        public List<Sofases> Get(string codigo="00004") 
        {
            // Lista para almacenar los sofas obtenidos de la base de datos
            List<Sofases> sofa= new List<Sofases>();

            // Consulta SQL para obtener los sofas y sus paises asociados
            string query = $"SELECT * FROM Sofas AS S INNER JOIN Paises AS P ON  S.CodigoP = P.Codigo";

            //string query = $"SELECT * FROM Sofas AS S INNER JOIN Paises AS P ON  S.CodigoP = P.Codigo WHERE S.Codigo = {codigo}";

            // Crear una conexión a la base de datos y ejecutar la consulta
            using (SqlConnection connection= new SqlConnection(connectionString))
            {
                // Crear un comando SQL con la consulta y la conexión
                SqlCommand command = new SqlCommand(query, connection);

                // Establecer la función de comando para que devuelva un DataReader
                connection.Open();

                // Ejecutar el comando y obtener un SqlDataReader
                SqlDataReader reader = command.ExecuteReader();

                // Leer los resultados de la consulta y crear objetos Sofases
                while (reader.Read())
                { 
                    
                    string Codigo = reader.GetString(0);
                    string NombreSofas = reader.GetString(1);
                    string ColorSofas = reader.GetString(2);
                    string CodigoP = reader.GetString(3);
                    string CodigoPais = reader.GetString(4);
                    string NombrePais = reader.GetString(5);
                    int NumHabitantes = reader.GetInt32(6);
                    Sofases sofa_ = new Sofases(CodigoPais,NombrePais,NumHabitantes,Codigo,NombreSofas,ColorSofas);
                    sofa.Add(sofa_);

                }
                // Cerrar el SqlDataReader y la conexión
                reader.Close();
                connection.Close();
            }
            // Devolver la lista de sofas obtenidos
            return sofa;
        }

        public void Add(Sofases sofa) {
            string query = $"INSERT INTO Sofas(Codigo,Nombre,Color,CodigoP)"+
                //Una buena práctica es usar parámetros para evitar inyecciones SQL
                $"VALUES (@Codigo,@Nombre,@Color,@CodigoP)";

            using (var connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new(query, connection);
                // Del commando SQL, se añaden los parámetros con sus valores
                command.Parameters.AddWithValue("@Codigo",sofa.Codigo);
                command.Parameters.AddWithValue("@Nombre", sofa.NombreSofas);
                command.Parameters.AddWithValue("@Color", sofa.ColorSofas);
                command.Parameters.AddWithValue("@CodigoP", sofa.CodigoP);


                connection.Open();
                // Ejecutar el comando SQL para insertar el nuevo sofa
                command.ExecuteNonQuery();

                connection.Close();
            }

        }
        public void Edit(Sofases sofa)
        {
            string query = $"UPDATE Sofas SET Nombre=@Nombre,Color=@Color,CodigoP=@CodigoP WHERE Codigo=@Codigo";
          

            using (var connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new(query, connection);
                // Del commando SQL, se añaden los parámetros con sus valores
                command.Parameters.AddWithValue("@Codigo", sofa.Codigo);
                command.Parameters.AddWithValue("@Nombre", sofa.NombreSofas);
                command.Parameters.AddWithValue("@Color", sofa.ColorSofas);
                command.Parameters.AddWithValue("@CodigoP", sofa.CodigoP);


                connection.Open();
                // Ejecutar el comando SQL para insertar el nuevo sofa
                command.ExecuteNonQuery();

                connection.Close();
            }

        }

        public void Delete(Sofases sofa)
        {
            string query = $"DELETE FROM Sofas WHERE Codigo=@Codigo";


            using (var connection = new SqlConnection(connectionString))
            {

                var command = new SqlCommand(query, connection);
                // Del commando SQL, se añaden los parámetros con sus valores
                command.Parameters.AddWithValue("@Codigo", sofa.Codigo);


                connection.Open();
                // Ejecutar el comando SQL para insertar el nuevo sofa
                command.ExecuteNonQuery();

                connection.Close();
            }

        }

    }

}
