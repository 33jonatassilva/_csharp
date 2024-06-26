
using System.Text;


namespace Test
{
    static class ProductFunc
    {


        public static string GenerateID()
        {
            const string chars = "0123456789";
            Random random = new Random();
            StringBuilder id = new StringBuilder(6);

            for (int i = 0; i < 6; i++)
            {
                int index = random.Next(chars.Length);
                id.Append(chars[index]);
            }

            return id.ToString();
        }

        public static Product insertProduct()
        {

            Product product = new Product();

            Console.Write("Digite o nome do produto: ");
            product._name = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite a categoria do produto: ");
            product._category = Console.ReadLine() ?? string.Empty;


            Console.Write("Digite o valor do produto: ");
            product._value = float.Parse(Console.ReadLine() ?? string.Empty);


            Console.Write("Digite a quantidade do produto: ");
            product._quantity = int.Parse(Console.ReadLine() ?? string.Empty);


            return product;
        }

        public static void editProduct()
        {

            Console.Write("Digite o Id do produto: ");
            string id = Console.ReadLine() ?? string.Empty;

        start:
            
            
            Menu.editProduct();



            string option = Console.ReadLine() ?? string.Empty;

            Console.Write("Digite o valor para substituí-lo: ");
            var replace = Console.ReadLine();

            switch (int.Parse(option))
            {
                case 1:
                    DatabaseColector.ExecuteQuery(2, $"UPDATE dbo_products SET name = \'{replace}\' WHERE idProduct = \'{id}\';");
                    break;

                case 2:
                    DatabaseColector.ExecuteQuery(2,$"UPDATE dbo_products SET category = {replace} WHERE idProduct = {id};");
                    break;

                case 3:
                    DatabaseColector.ExecuteQuery(2, $"UPDATE dbo_products SET value = {replace} WHERE idProduct = \'{id}\';");
                    break;

                case 4:
                    DatabaseColector.ExecuteQuery(2, $"UPDATE dbo_products SET quantity = {replace} WHERE idProduct = \'{id}\';");
                    break;


                default:
                    Console.Write("Opção inválida! Escolha uma dentre as opções:\n\n");
                    goto start;
            }
        }


        public static void deleteProduct()
        {
            Console.Write("Digite o id do produto: ");
            string id = Console.ReadLine() ?? string.Empty;


            if (id.Length == 5)
            {
                DatabaseColector.ExecuteQuery(2, $"DELETE FROM dbo_products WHERE idProduct = \'{id}\';");
                return;
            }

            Console.Write("Id inválido! Tente novamente");
            return;

        }


        public static void consultProduct()
        {

            Console.Write("Digite o id do produto: ");


            string id = Console.ReadLine() ?? string.Empty;

            if (id.Length == 6)
            {
                DatabaseColector.ExecuteQuery(2, $"SELECT * FROM dbo_products WHERE idProduct = \'{id}\'");
                return;
            }

            Console.Write("Id inválido! Tente novamente");
            return;

        }


        public static void listProducts()
        {
            DatabaseColector.ExecuteQuery(2, "SELECT * FROM dbo_products");
        }


        public static void addProduct(Product product)
        {
            DatabaseColector.ExecuteQuery(2, $"INSERT INTO dbo_Products() VALUES (\'{GenerateID()}\', \'{product._name}\', \'{product._category}\', \'{product._value}\', {product._quantity})");
        }



        public static void choicesOfActionInProducts(int option)
        {
            switch (option)
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
                    default:
                        break;
                }
        }

    }

}