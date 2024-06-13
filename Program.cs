

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Jonatas", "Silva", "jonatasbsilva1@outlook.com", "1234", 21, 175, "000-000-000-00");
            Product product = new Product("111222", "Melancia", "Fruta", 7.5f, 50);


            Employee employee = new Employee("1111", "Supervisor", 7000, "Jonatas", "Silva", "jonatasbsilva1@outlook.com", "1234", 21, 175, "000-000-000-00");

            Console.WriteLine(employee.ToString());
            

           
            //Console.WriteLine(person.ToString());
            
            //Console.WriteLine(product.ToString());
        }
    }
}
