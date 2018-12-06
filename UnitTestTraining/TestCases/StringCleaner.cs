using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UnitTestTraining.TestCases
{
    public class StringCleaner
    {
        public static string Clean(string text) 
            => Regex.Replace(text, @"\s+", "");

    }
}
