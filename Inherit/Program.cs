using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using ClassLibrary1;

namespace Inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            var comm = new CommissionLibrary();

            WriteLine("AAAAAAAAAAAA");
            WriteLine(comm.Plus(1, 1));
            WriteLine();

            WriteLine("BBBBBBBBBBB");
            WriteLine(comm.Minus(1, 1));
            WriteLine();

            WriteLine("CCCCCCCCCCCC");

            var request = new FormatModelRequest() { Value = "Heyy" };
            var result = comm.Format(request);
            WriteLine(result.Value);
            WriteLine();

            Read();
        }
    }
}
