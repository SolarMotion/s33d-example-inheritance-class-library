using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class TestA : ITestA
    {
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
}
