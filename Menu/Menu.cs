

namespace Test
{
    static class Menu
    {   

        public static void Start()
        {
            Console.Write("\n1. Usuários\n" +
                            "2. Produtos\n\n" +
                            "Digite uma opção válida: ");
        }

        public static void Employee()
        {
            Console.Write(
                    "\n1. Cadastrar usuário\n" +
                    "2. Editar usuário\n" +
                    "3. Excluir usuário\n" +
                    "4. Consultar usuário\n" +
                    "5. Listar usuário\n" +
                    "0. Voltar\n\n" + 
                    "Digite uma opcão válida: ");
        }

        public static void Product()
        {
            Console.Write(
                    "\n1. Cadastrar produto\n" +
                    "2. Editar produto\n" +
                    "3. Excluir produto\n" +
                    "4. Consultar produto\n" +
                    "5. Listar produtos\n" +
                    "0. Voltar\n\n" + 
                    "Digite uma opcão válida: ");
        }


        public static void editProduct()
        {
            Console.Write(
                "1. name\n" +
                "2. category\n" +
                "3. value\n" +
                "4. quantity\n\n" +
               
                "Digite a opção desejada: "
            );
        }


        public static void editEmployee()
        {
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
        }



        
        
                public static string[] Display()
        {

            string[] option = new string[2];

        begin:
            Menu.Start();

            option[0] = Console.ReadLine() ?? string.Empty;


            if (int.Parse(option[0]) == 1)
            {
                do
                {
                    Menu.Employee();

                    option[1] = Console.ReadLine() ?? string.Empty;

                } while (int.Parse(option[1]) < 0 || int.Parse(option[1]) > 5);
            }

            else if (int.Parse(option[0]) == 2)
            {

                do
                {

                    Menu.Product();

                    option[1] = Console.ReadLine() ?? string.Empty;

                } while (int.Parse(option[1]) < 0 || int.Parse(option[1]) > 5);


                //return int.Parse(option);
            }

            else if (int.Parse(option[0]) != 0)
            {
                Console.Write("Opção inválida, tente novamente\n");
                goto begin;
            }
            else
            {

                Console.WriteLine("\nPrograma encerrado com sucesso!\n");

            }
            return option;
        }
    }
}