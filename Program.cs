

namespace Test
{
    class Program
    {

        public static string[] Menu()
        {

            string[] option = new string[2];

        begin:
            Console.Write("\n1. Usuários\n" +
                              "2. Produtos\n\n" +
                              "Digite uma opção válida: ");

            option[0] = Console.ReadLine() ?? string.Empty;


            if (int.Parse(option[0]) == 1)
            {
                do
                {
                    Console.Write(
                    "\n1. Cadastrar usuário\n" +
                    "2. Editar usuário\n" +
                    "3. Excluir usuário\n" +
                    "4. Consultar usuário\n" +
                    "5. Listar usuário\n\n" +
                    "Digite uma opcão válida: ");



                    option[1] = Console.ReadLine() ?? string.Empty;

                } while (int.Parse(option[1]) < 1 || int.Parse(option[1]) > 5);
            }

            else if (int.Parse(option[0]) == 2)
            {

                do
                {
                    Console.Write(
                    "\n1. Cadastrar produto\n" +
                    "2. Editar produto\n" +
                    "3. Excluir produto\n" +
                    "4. Consultar produto\n" +
                    "5. Listar produtos\n\n" +
                    "Digite uma opcão válida: ");

                    option[1] = Console.ReadLine() ?? string.Empty;

                } while (int.Parse(option[1]) < 1 || int.Parse(option[1]) > 5);


                //return int.Parse(option);
            }

            else
            {
                Console.Write("Opção inválida, tente novamente\n");
                goto begin;
            }

            return option;
        }



        public static void Main(string[] args)
        {

            string[] option = Menu();

            if(int.Parse(option[0]) == 1)
            {
                switch (int.Parse(option[1]))
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
                }
            } 
            
            else 
            {
                switch (int.Parse(option[1]))
                {
                    case 1:
                        ProductFunc.addProduct(ProductFunc.insertProduct());
                        break;
                    case 2:
                        ProductFunc.editProduct();
                        break;
                    case 3:
                        ProductFunc.deleteProduct();
                        break;
                    case 4: 
                        ProductFunc.consultProduct();
                        break;
                    case 5:
                        ProductFunc.listProducts();
                        break;
                }
            } 
        }
    }
}
