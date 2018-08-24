using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Player : MarshalByRefObject
    {
        public void SayHello(string text)
        {
            Console.WriteLine("The Client says: " + text);
        }
    }
