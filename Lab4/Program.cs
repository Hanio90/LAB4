using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)

        {
            long i, number, fact;

                Console.WriteLine("Hello! Please enter an integer between 1 and 10");

                number = int.Parse(Console.ReadLine());
                fact = number;

                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine("Factorial of given Number is : " + fact);

            Console.WriteLine("Continue? Y/N" );
            string response = Console.ReadLine();

            if (response.ToLower() == "yes" || response.ToLower() == "y" )
            Main(args);

            else
                Console.WriteLine("Goodbye");

           // Console.WriteLine(GetFactorial(5));

        }

        /*public static long GetFactorial(int n)

        {
            if (n == 1)
                return 1;

            return (n * GetFactorial(n - 1));
        } */
    }
}
