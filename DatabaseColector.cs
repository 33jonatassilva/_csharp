using System;
using MySql.Data.MySqlClient;

public static class DatabaseColector
{
    private static string connectionString = "Server=localhost;Database=salessystem;User=root;";

    public static void ExecuteQuery(string query)
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
                        // Supondo que sua tabela tenha colunas 'Id' e 'Nome'
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



                        Console.WriteLine($"\nNome: {first_name + " " + last_name}\nCargo: {job}\nSalary: {salary}\nIdade: {age}\nAltura: {height}\nCPF: {cpf}\nE-mail: {email}\nSenha: {password}\n");
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
