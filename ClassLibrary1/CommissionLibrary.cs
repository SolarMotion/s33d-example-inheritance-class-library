using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CommissionLibrary : ITestA, ITestB, ITestC
    {
        TestA testA = new TestA();
        TestB testB = new TestB();
        TestC testC = new TestC();

        public int Plus(int a, int b)
        {
            return testB.Plus(a, b);
        }

        public int Minus(int a, int b)
        {
            return testA.Minus(a, b);
        }

        public FormatModelResponse Format(FormatModelRequest request)
        {
            return testC.Format(request);
        }
    }
}
