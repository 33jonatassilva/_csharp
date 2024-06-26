
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
            employee.FirstName = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite o sobrenome do usuário: ");
            employee.LastName = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite a função do usuário: ");
            employee.Job = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite o salário do usuário: ");
            employee.Salary = int.Parse(Console.ReadLine() ?? string.Empty) ;


            Console.Write("Digite o e-mail do usuário: ");
            employee.Email = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite o idade do usuário: ");
            employee.Age = int.Parse(Console.ReadLine() ?? string.Empty) ;


            Console.Write("Digite o senha do usuário: ");
            employee.Password = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite o altura do usuário: ");
            employee.Height = float.Parse(Console.ReadLine() ?? string.Empty);


            Console.Write("Digite o cpf do usuário: ");
            employee.Cpf = Console.ReadLine() ?? string.Empty;


            return employee;
        }

        public static void editEmployee()
        {

            Console.Write("Digite o Id do usuário: ");
            string id = Console.ReadLine() ?? string.Empty;

        start:
            
            Menu.editEmployee();



            string option = Console.ReadLine() ?? string.Empty;

            Console.Write("Digite o valor para substituí-lo: ");
            var replace = Console.ReadLine();

            switch (int.Parse(option))
            {
                case 1:
                    DatabaseColector.ExecuteQuery(1, $"UPDATE dbo_employees SET job = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;

                case 2:
                    DatabaseColector.ExecuteQuery(1, $"UPDATE dbo_employees SET salary = {replace} WHERE idUser = {id};");
                    break;

                case 3:
                    DatabaseColector.ExecuteQuery(1, $"UPDATE dbo_employees SET first_name = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;

                case 4:
                    DatabaseColector.ExecuteQuery(1, $"UPDATE dbo_employees SET last_name = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;

                case 5:
                    DatabaseColector.ExecuteQuery(1, $"UPDATE dbo_employees SET email = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;
                case 6:
                    DatabaseColector.ExecuteQuery(1, $"UPDATE dbo_employees SET password = \'{replace}\' WHERE idUser = \'{id}\';");
                    break;

                case 7:
                    DatabaseColector.ExecuteQuery(1, $"UPDATE dbo_employees SET age = {replace} WHERE idUser = {id};");
                    break;

                case 8:
                    DatabaseColector.ExecuteQuery(1, $"UPDATE dbo_employees SET height = {replace} WHERE idUser = {id};");
                    break;

                case 9:
                    DatabaseColector.ExecuteQuery(1, $"UPDATE dbo_employees SET cpf = \'{replace}\' WHERE idUser = \'{id}\';");
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
                DatabaseColector.ExecuteQuery(1, $"DELETE FROM dbo_employees WHERE id = \'{id}\';");
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
                DatabaseColector.ExecuteQuery(1, $"SELECT * FROM dbo_employees WHERE idUser = \'{id}\'");
                return;
            }

            Console.Write("Id inválido! Tente novamente");
            return;

        }


        public static void listEmployees()
        {
            DatabaseColector.ExecuteQuery(1, "SELECT * FROM dbo_employees");
        }


        public static void addEmployee(Employee employee)
        {
            DatabaseColector.ExecuteQuery(1, $"INSERT INTO dbo_employees() VALUES (\'{GenerateID()}\', \'{employee.FirstName}\', \'{employee.LastName}\', \'{employee.Email}\', {employee.Salary}, \'{employee.Password}\', \'{employee.Age}\', {employee.Height}, \'{employee.Cpf}\', \'{employee.Job}\')");
        }


        public static void choicesOfActionInEmployees(int option)
        {
            switch (option)
                {
                    case 1:
                        EmployeeFunc.addEmployee(EmployeeFunc.insertEmployee());
                        break;
                    case 2:
                        EmployeeFunc.editEmployee();
                        break;
                    case 3:
                        EmployeeFunc.deleteEmployee();
                        break;
                    case 4: 
                        EmployeeFunc.consultEmployee();
                        break;
                    case 5:
                        EmployeeFunc.listEmployees();
                        break;
                    default:
                        break;
            
                }
        }

    }

}