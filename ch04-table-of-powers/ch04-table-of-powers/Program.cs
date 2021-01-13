using System;

namespace ch04_table_of_powers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the table of powers");
            Console.Write("Enter an integer: ");
            String num = Console.ReadLine();
            Double num1 = Convert.ToDouble(num);

            for (int i = 0; i < num1; i++)

            {
                Double num1sq = i * i;
                Double num1cu = i * i * i;
                

            }


        }
    }
}
