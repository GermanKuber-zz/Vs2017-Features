using System;
using System.Threading.Tasks;

namespace Vs2017Features
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new Client().Speak();
            Console.WriteLine("Test");

            new Example6();
            Console.ReadKey();
        }

        public static async Task TestAsync()
        {
            await Task.CompletedTask;
        }
    }
}
