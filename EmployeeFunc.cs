
using System.Text;


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

            Console.Write("Digite o nome do usuário: ");
            employee._first_name = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite o sobrenome do usuário: ");
            employee._last_name = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite a função do usuário: ");
            employee._job = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite o salário do usuário: ");
            employee._salary = int.Parse(Console.ReadLine() ?? string.Empty) ;


            Console.Write("Digite o e-mail do usuário: ");
            employee._email = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite o idade do usuário: ");
            employee._age = int.Parse(Console.ReadLine() ?? string.Empty) ;


            Console.Write("Digite o senha do usuário: ");
            employee._password = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite o altura do usuário: ");
            employee._height = float.Parse(Console.ReadLine() ?? string.Empty);


            Console.Write("Digite o cpf do usuário: ");
            employee._cpf = Console.ReadLine() ?? string.Empty;


            return employee;
        }

        public static void editEmployee()
        {

            Console.Write("Digite o Id do usuário: ");
            string id = Console.ReadLine() ?? string.Empty;

        start:
            Console.Write(
                "1. job\n" +
                "2. salary\n" +
                "3. first_name\n" +
                "4. last_name\n" +
                "5. email\n" +
                "6. password\n" +
                "7. age\n" +
                "8. height\n" +
                "9. cpf\n\n" +
                "Digite a opção desejada: "
            );



            string option = Console.ReadLine() ?? string.Empty;

            Console.Write("Digite o valor para substituí-lo: ");
            var replace = Console.ReadLine();

            switch (int.Parse(option))
            {
                case 1:
                    DatabaseColector.ExecuteQuery($"UPDATE dbo_employees SET job = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;

                case 2:
                    DatabaseColector.ExecuteQuery($"UPDATE dbo_employees SET salary = {replace} WHERE idUser = {id};");
                    break;

                case 3:
                    DatabaseColector.ExecuteQuery($"UPDATE dbo_employees SET first_name = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;

                case 4:
                    DatabaseColector.ExecuteQuery($"UPDATE dbo_employees SET last_name = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;

                case 5:
                    DatabaseColector.ExecuteQuery($"UPDATE dbo_employees SET email = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;
                case 6:
                    DatabaseColector.ExecuteQuery($"UPDATE dbo_employees SET password = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;

                case 7:
                    DatabaseColector.ExecuteQuery($"UPDATE dbo_employees SET age = {replace} WHERE idUser = {id};");
                    break;

                case 8:
                    DatabaseColector.ExecuteQuery($"UPDATE dbo_employees SET height = {replace} WHERE idUser = {id};");
                    break;

                case 9:
                    DatabaseColector.ExecuteQuery($"UPDATE dbo_employees SET cpf = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;

                default:
                    Console.Write("Opção inválida! Escolha uma dentre as opções:\n\n");
                    goto start;
            }
        }


        public static void deleteEmployee()
        {
            Console.Write("Digite o id do funcionário: ");
            string id = Console.ReadLine() ?? string.Empty;


            if (id.Length == 5)
            {
                DatabaseColector.ExecuteQuery($"DELETE FROM dbo_employees WHERE id = \'{id}\';");
                return;
            }

            Console.Write("Id inválido! Tente novamente");
            return;

        }


        public static void consultEmployee()
        {

            Console.Write("Digite o id do funcionário: ");


            string id = Console.ReadLine() ?? string.Empty;

            if (id.Length == 5)
            {
                DatabaseColector.ExecuteQuery($"SELECT * FROM dbo_employees WHERE idUser = \'{id}\'");
                return;
            }

            Console.Write("Id inválido! Tente novamente");
            return;

        }


        public static void listEmployees()
        {
            DatabaseColector.ExecuteQuery("SELECT * FROM dbo_employees");
        }


        public static void addEmployee(Employee employee)
        {
            DatabaseColector.ExecuteQuery($"INSERT INTO dbo_employees() VALUES (\'{GenerateID()}\', \'{employee._first_name}\', \'{employee._last_name}\', \'{employee._email}\', {employee._salary}, \'{employee._password}\', \'{employee._age}\', {employee._height}, \'{employee._cpf}\', \'{employee._job}\')");
        }

    }

}