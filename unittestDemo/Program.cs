using UnittestDemo;

namespace unittestDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MathHelper.sumTwoNumbers(5, 6);
            MathHelper.CountDown(3);
            Console.WriteLine(TextFormating.nameCase("nAGliS"));
        }
    }
}
