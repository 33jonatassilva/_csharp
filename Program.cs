using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;



namespace Test
{

    class Program
    {

        public static string[] Menu()
        {

            string[] option = new string[2];

        begin:
            Console.WriteLine("\n1. Usuários\n" +
                              "2. Produtos\n\n" +
                              "Digite uma opção válida: ");

            option[0] = Console.ReadLine();

            if (option[0] == null) return null;


            if (int.Parse(option[0]) == 1)
            {
                do
                {
                    Console.WriteLine(
                    "\n1. Cadastrar usuário\n" +
                    "2. Editar usuário\n" +
                    "3. Excluir usuário\n" +
                    "4. Consultar usuário\n" +
                    "5. Listar produtos\n\n" +
                    "Digite uma opcão válida: ");



                    option[1] = Console.ReadLine();

                } while (int.Parse(option[1]) < 1 || int.Parse(option[1]) > 5);

                //return int.Parse(option[1]);
            }

            else if (int.Parse(option[0]) == 2)
            {

                do
                {
                    Console.WriteLine(
                    "\n1. Cadastrar produto\n" +
                    "2. Editar produto\n" +
                    "3. Excluir produto\n" +
                    "4. Consultar produto\n" +
                    "5. Listar produtos\n\n" +
                    "Digite uma opcão válida: ");

                    option[1] = Console.ReadLine();

                } while (int.Parse(option[1]) < 1 || int.Parse(option[1]) > 5);


                //return int.Parse(option);
            }

            else
            {
                Console.WriteLine("Opção inválida, tente novamente\n");
                goto begin;
            }

            return option;
        }

        public static void Main(string[] args)
        {
            int[] option = new int[2];
            string[] aux = Menu();

            option[0] = int.Parse(aux[0]);
            option[1] = int.Parse(aux[1]);


            Dictionary<string, Employee> Organization = new Dictionary<string, Employee>();
            Dictionary<string, Employee> Stock = new Dictionary<string, Employee>();


            Employee auxEmp = new Employee();
            EmployeeFunc slave = new EmployeeFunc();

            Product auxPro = new Product();


            if (option[0] == 1)
            {

                switch (option[1])
                {

                    case 1:

                        Organization.Add(slave.GenerateID(), slave.insertEmployee());
                        break;

                    case 2:



                    case 3:

                        slave.deleteEmployee(Organization);
                        break;

                    case 4:

                        slave.consultEmployee(Organization);
                        break;

                    case 5:
                        Console.WriteLine(slave.ToString());
                        break;
                    default:
                        break;


                }

            }

            switch (option[1])
            {

                case 1:

                case 2:

                case 3:

                case 4:

                case 5:

                default:
                    return;
            }




        }
    }
}
