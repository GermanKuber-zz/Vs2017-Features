using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Vs2017Features
{
    class Example6
    {
        public Example6(HttpStatusCode code)
        {
            if (2 > 1)
                Console.WriteLine("Primero");
            else
                Console.WriteLine("Primero");


            if (code == HttpStatusCode.OK)
                Console.WriteLine("Ok" + code);
            else if (code == HttpStatusCode.ExpectationFailed)
                Console.WriteLine("ExpectationFailed");

        }
    }
}
