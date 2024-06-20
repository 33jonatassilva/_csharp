

using System.Data.Common;
using System.Text;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using MySql.Data.MySqlClient;



namespace Test
{
    static class EmployeeFunc
    {

        
        public static string GenerateID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            StringBuilder id = new StringBuilder(5);

            for (int i = 0; i < 5; i++)
            {
                int index = random.Next(chars.Length);
                id.Append(chars[index]);
            }

            return id.ToString();
        }

        public static Employee insertEmployee()
        {

            Employee employee = new Employee();

            Console.WriteLine("Digite o nome do usuário: ");
            employee._first_name = Console.ReadLine();


            Console.WriteLine("Digite o sobrenome do usuário: ");
            employee._last_name = Console.ReadLine();


            Console.WriteLine("Digite a função do usuário: ");
            employee._job = Console.ReadLine();


            Console.WriteLine("Digite o salário do usuário: ");
            employee._salary = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o e-mail do usuário: ");
            employee._email = Console.ReadLine();


            Console.WriteLine("Digite o idade do usuário: ");
            employee._age = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o senha do usuário: ");
            employee._password = Console.ReadLine();


            Console.WriteLine("Digite o altura do usuário: ");
            employee._height = float.Parse(Console.ReadLine());


            Console.WriteLine("Digite o cpf do usuário: ");
            employee._cpf = Console.ReadLine();


            return employee;
        }

        public static void editEmployee(Dictionary<string, Employee> employees)
        {

            string id = Console.ReadLine();


            Console.WriteLine(
                "1. job\n" +
                "2. salary\n" +
                "3. first_name\n" +
                "4. last_name\n" +
                "5. email\n" +
                "6. password\n" +
                "7. age\n" +
                "8. height\n" +
                "9. cpf"
            );

            string option = Console.ReadLine();

            switch (int.Parse(option))
            {
              //case 1
            }
        }


        public static void deleteEmployee()
        {
            Console.WriteLine("Digite o id do funcionário: ");
            string id = Console.ReadLine();
            
            
            if(id.Length == 5)
                {
                    DatabaseColector.ExecuteQuery($"DELETE FROM dbo_employees WHERE id = {id}");
                    return;
                }
            
                Console.WriteLine("Id inválido! Tente novamente");
                return;
            

        }


        public static void consultEmployee()
        {
            //Employee employee = new Employee();

            Console.WriteLine("Digite o id do funcionário: ");


            string id = Console.ReadLine();

            if(id.Length == 5)
                {
                    DatabaseColector.ExecuteQuery($"SELECT * FROM dbo_employees WHERE idUser = \'{id}\'");
                    return;
                }
            
                Console.WriteLine("Id inválido! Tente novamente");
                return;

        }


        public static void addEmployee(Employee employee)
        {
            DatabaseColector.ExecuteQuery($"INSERT INTO dbo_employees() VALUES ({GenerateID()}, {employee._first_name}, {employee._last_name}, {employee._email}, {employee._salary}, {employee._password}, {employee._age}, {employee._height}, {employee._cpf}, {employee._job})");
        }
            
    }

}