using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal interface ITestB
    {
        int Plus(int a, int b);
    }

    internal class TestB : ITestB
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
    }
}
