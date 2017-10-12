using System;
namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Zdravo narode");
            System.Console.ReadKey(true);

            int sum = 0;
            for (int i = 0; i < 100; i++)
                sum += i;
            Console.WriteLine(sum);

        }
    }
}
