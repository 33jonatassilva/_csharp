

using System.Reflection.Emit;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
        begin:

            string[] option = Display();

            if (int.Parse(option[0]) == 1)
            {
                EmployeeFunc.choicesOfActionInEmployees(int.Parse(option[1]));
            }

            else if (int.Parse(option[0]) == 2)
            {
                ProductFunc.choicesOfActionInProducts(int.Parse(option[1]));
            }
            goto begin;
        }
    }
}
