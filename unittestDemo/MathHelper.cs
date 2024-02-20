using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unittestDemo
{
    public class MathHelper
    {

        public static int getDividorsCount(int num)//10 1,2,5
        {
            // num = (int)Math.Sqrt(num * num);
            num = Math.Abs(num);
            int count = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static void CountDown(int num)//3; 2; 1; 0
        {
            if (num == 0)
            {
                Console.WriteLine("Blast off!");
            }
            else
            {
                CountDown(num - 1); // Recursive call
            }
            Console.WriteLine(num);//3; 2; 1 
        }



        public static int sumTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public static double sumTwoNumbers(double a, double b)
        {
            return a + b;
        }
        public static float sumTwoNumbers(float a, float b)
        {
            return a + b;
        }
        public static decimal sumTwoNumbers(decimal a, decimal b)
        {
            return a + b;
        }
    }
}
