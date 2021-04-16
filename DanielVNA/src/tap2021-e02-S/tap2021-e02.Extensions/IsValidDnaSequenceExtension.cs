using System;
using System.Text.RegularExpressions;

namespace tap2021_e02.Extensions
{
    public static class IsValidDnaSequenceExtension
    {
        public static bool StringCharactersValidation(string sampleTest)
        {

            Regex regExpr = new Regex("A|C|G|T");
            bool containsAny = regExpr.IsMatch(sampleTest);
            return containsAny;
        }
        public static bool IsValid(this Sample sample)
        {
            string SampleTest = sample.DataAnalysis;

            if (SampleTest.Length == 1000 && StringCharactersValidation(SampleTest))
                return true;
            else
                return false;
        }

    }
}
