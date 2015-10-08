using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleCodeBaseforGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            string oputput = GetValue("Hello World");
            AddANewMethod();
        }

        private static void AddANewMethod()
        {
            throw new NotImplementedException();
        }

        public static string GetValue(string input)
        {
            return input;
        }

        public static string GoVersion()
        {
            return "OKK";
        }

    }


}
