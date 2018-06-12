using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vs2017Features
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.ReadKey();
        }

        public static async Task TestAsync()
        {
            await Task.CompletedTask;
        }

        public static  List<Client> GetList()
        {
            return null;
        }
    }
}
