
using MySql.Data.MySqlClient;

public static class DatabaseColector
{
    private static string connectionString = "Server=localhost;Database=salessystem;User=root;";

    public static void ExecuteQuery(int option, string query)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);


                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        switch (option)
                        {
                            case 1:

                    
                                string id = reader.GetString("idUser");
                                string first_name = reader.GetString("first_name");
                                string last_name = reader.GetString("last_name");
                                string email = reader.GetString("email");
                                string job = reader.GetString("job");
                                string cpf = reader.GetString("cpf");
                                float salary = reader.GetFloat("salary");
                                string password = reader.GetString("password");
                                int age = reader.GetInt32("age");
                                float height = reader.GetFloat("height");



                                Console.WriteLine($"\nId: {id}\nNome: {first_name + " " + last_name}\nCargo: {job}\nSalary: {salary}\nIdade: {age}\nAltura: {height}\nCPF: {cpf}\nE-mail: {email}\nSenha: {password}\n");


                                break;

                            case 2:


                                int idProduct = reader.GetInt32("idProduct");
                                string name = reader.GetString("name");
                                string category = reader.GetString("category");
                                int quantity = reader.GetInt32("quantity");
                                float value = reader.GetFloat("value");

                                Console.WriteLine($"\nId: {idProduct}\nName: {name}\nCategory: {category}\nQuantity: {quantity}\n");


                                break;

                        }
                    }     
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}
