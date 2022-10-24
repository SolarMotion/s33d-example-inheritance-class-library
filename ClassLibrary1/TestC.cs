using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal interface ITestC
    {
        FormatModelResponse Format(FormatModelRequest request);
    }

    internal class TestC : ITestC
    {
        public FormatModelResponse Format(FormatModelRequest request)
        {
            return new FormatModelResponse() { Value = $"Returned ===> {request.Value}" };
        }
    }

    public class FormatModelRequest
    {
        public string Value { get; set; }
    }

    public class FormatModelResponse
    {
        public string Value { get; set; }
    }
}

