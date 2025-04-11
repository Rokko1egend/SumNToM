/*
 * Author: Elliot Jost
 * Date: 2025-04-10
 * Description: This lab tests the ability to make a recursive algorithym
 * This lab adds the numbers between two inputed numbers.
 */

namespace RecursionLab
{
    class RecursionLab
    {
        static int SumNToM(int num1, int num2)
        {
            if (num1 > num2)
            {
                return 0;
            }
            return num1 + SumNToM (num1+1, num2);
        }

        static int DevidableBy2(int num)
        {
            if(num %2 != 0)
            {
                return 0;
            }
            return 1+ DevidableBy2 (num/2);
        }

        static void Main()
        {
            Console.WriteLine("Addition\nEnter number n:");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            Console.WriteLine("\nEnter number m:");
            input = Console.ReadLine();
            int m = Convert.ToInt32(input);
            Console.WriteLine(SumNToM(n,m));

            Console.WriteLine("\nDivision\nEnter your number:");
            input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            Console.WriteLine(DevidableBy2(num));

        }
    }
}