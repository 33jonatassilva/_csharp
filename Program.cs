

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Jonatas", "Silva", "jonatasbsilva1@outlook.com", "1234", 21, 175, "000-000-000-00");
            
           
            Console.WriteLine(person.ToString());
            
        }
    }
}
