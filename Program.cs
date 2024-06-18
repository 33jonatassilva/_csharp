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

            if(option[0] == null) return null;


            if(int.Parse(option[0]) == 1)
            {
                do
                {
                Console.WriteLine(
                "\n1. Cadastrar usuário\n" +
                "2. Editar usuário\n" + 
                "3. Excluir usuário\n" + 
                "4. Consultar usuário\n\n" +
                "Digite uma opcão válida: ");

                

                option[1] = Console.ReadLine();

                } while(int.Parse(option[1]) < 1 || int.Parse(option[1]) > 4);

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
                "4. Consultar produto\n\n" +
                "Digite uma opcão válida: ");

                option[1] = Console.ReadLine();

                } while(int.Parse(option[1]) < 1 || int.Parse(option[1]) > 4);


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


            List<Employee> Organization = new List<Employee>();
            List<Product> Estoque = new List<Product>();

            Employee auxEmp = new Employee();
            Product auxPro = new Product();


            if(option[0] == 1)
            {

            switch (option[1]) {


                
                case 1:

                    Console.WriteLine("Digite o nome do usuário: ");
                    auxEmp._first_name = Console.ReadLine();
                    Console.WriteLine("Digite o sobrenome do usuário: ");
                    auxEmp._last_name = Console.ReadLine();
                    Console.WriteLine("Digite a função do usuário: ");
                    auxEmp._job = Console.ReadLine();
                    Console.WriteLine("Digite o salário do usuário: ");
                    auxEmp._salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o e-mail do usuário: ");
                    auxEmp._email = Console.ReadLine();
                    Console.WriteLine("Digite o idade do usuário: ");
                    auxEmp._age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o senha do usuário: ");
                    auxEmp._password = Console.ReadLine();
                    Console.WriteLine("Digite o altura do usuário: ");
                    auxEmp._height = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o cpf do usuário: ");
                    auxEmp._cpf = Console.ReadLine();

                    Organization.Add(auxEmp);


                    Console.WriteLine(auxEmp.ToString());
                    break;

                case 2:

                case 3:

                case 4:

                case 5:

                default:
                    return;

        
            }

            } 

            switch (option[1]) {
                
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
