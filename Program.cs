using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
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

            EmployeeFunc.consultEmployee();

        }
    }
}
