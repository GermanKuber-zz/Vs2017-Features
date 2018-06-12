using System;
using System.Collections.Generic;
using System.Linq;

namespace Vs2017Features
{
    class Example6
    {
        public Client Client { get; set; }
        public Example6()
        {
            Console.WriteLine(Client.Name);
        }
    }
}
