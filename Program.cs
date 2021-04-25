using System;

namespace week2_lab_assignment
{
    class Program
    {
        public static void  remainder(int num1, int num2)
        {
            if (num1 < num2)
            {
                Console.WriteLine(num2 % num1);
            }
            else
            {
                Console.WriteLine(num1 % num2);
            }
        }
        static void Main(string[] args)
        {
         Program.remainder(25,30); //calling the static class member.
        }
    }
}
