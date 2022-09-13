using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDLL
{
    public class Simple
    {
        public string SayHello(string name) {
            return "Hello " + name;
        }

        public int sum(int a, int b) { 
            return a + b;
        }
    }
}
