using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goal3loopsndctrlstructres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- for loop--------------------------");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------- while loop--------------------------");
            int j = 1;
            while ( j<=5)
            {
            Console.WriteLine(j);
                j++;
            }
            Console.ReadLine();

            Console.WriteLine("---------------- control structures--------------------------");
            Console.WriteLine("input number to be tested");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 3== 0 && number % 7 == 0)
            {
                Console.WriteLine("This number is divisible by 3 and 7 ");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 3 and 7");       
            }
            Console.ReadLine();
        }
    }
}
