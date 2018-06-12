using System;
using System.Collections.Generic;
using System.Linq;

namespace Vs2017Features
{
    class Example4
    {
        List<Client> _clients = new List<Client>();
        public Example4()
        {
            var count = (from client in _clients
                         where client.Age > 26 &&
                         client.Name.Length == 5
                         select client).Sum(x => x.Age);
        }
    }
}
