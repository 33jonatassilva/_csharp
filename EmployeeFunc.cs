

using System.Text;

namespace Test
{
    class EmployeeFunc
    {

        public string GenerateID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            StringBuilder id = new StringBuilder(5);

            for (int i = 0; i < 5; i++)
            {
                int index = random.Next(chars.Length);
                id.Append(chars[index]);
            }

            return id.ToString();
        }
        
        public Employee insertEmployee()
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

        public void editEmployee(Dictionary<string, Employee> employees)
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

                //case 1:

            }

        

        }

        public bool deleteEmployee(Dictionary<string, Employee> employees)
        {
            Console.WriteLine("Digite o id do funcionário: ");
            string id = Console.ReadLine();
            
            if(employees.Remove(id))
            {
                Console.WriteLine("Funcionário excluído com sucesso!");
                return true;
            }
        
            Console.WriteLine("\nFuncionário inexistente! Tente novamente :/ ");
            return false;

        }

        public void consultEmployee(Dictionary<string, Employee> dicio)
        {
            //Employee employee = new Employee();

            Console.WriteLine("Digite o id do funcionário: ");
            string id = Console.ReadLine();

            if(dicio.TryGetValue(id, out Employee employee))
            {
                Console.WriteLine(employee.ToString());
                return;
            }

            Console.WriteLine("Funcionário não encontrado. Tente novamente :/");
        }
    }
}