using System.ComponentModel.Design;
using System.Reflection;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;



namespace Test
{
    
    class Program
    {

        public static void Menu()
        {


            begin:
            Console.WriteLine("\n1. Usuários\n" +
                              "2. Produtos\n" +
                              "Digite uma opção: ");

            string option = Console.ReadLine();

            if(option == null) return;


            if(int.Parse(option) == 1)
            {
                Console.WriteLine(
                "1. Cadastrar usuário\n" +
                "2. Editar usuário\n" + 
                "3. Excluir usuário\n" + 
                "4. Consultar usuário");
            } 
            
            else if (int.Parse(option) == 2)
            {    
                Console.WriteLine(
                "1. Cadastrar produto\n" +
                "2. Editar produto\n" + 
                "3. Excluir produto\n" + 
                "4. Consultar produto");
            }

            else
            {
                Console.WriteLine("Opção inválida, tente novamente\n");
                goto begin;
            }
        }

        public static void Main(string[] args)
        {
            Menu();
        }
    }
}
