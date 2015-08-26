using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InflationaryEng
{
    public class ConvertWords
    {
        // Used a dictionary so I can add more key value pairs, it makes it simple to iterate through 
            private Dictionary<string, string> patterns = new Dictionary<string, string>();

            public string ConvertInput(string input)
            {
                // List needs to be from greates to smallest otherwise the replacing will continue to happen for every 
                // previous smaller number ie: one -> two then two -> three, etc...
                patterns.Add("[Tt]en", "Eleven");            // [Tt]en -> Eleven
                patterns.Add("[Nn](ine|ign)", "Ten");        // [Nn](ine|ign) -> Ten
                patterns.Add("[Ee]ight|[Aa]te", "Nine");     // [Ee]ight|[Aa]te -> Nine
                patterns.Add("[Ss]even", "Eight");           // [Ss]even -> Eight
                patterns.Add("[Ss]ix", "Seven");             // [Ss]ix -> Seven
                patterns.Add("[Ff]ive", "Six");              // [Ff]ive -> Six
                patterns.Add("[Ff](our|ore|or)", "Five");    // [Ff](our|ore|or) -> Five
                patterns.Add("[Tt](hree|ree)", "Four");      // [Tt](hree|ree) -> Four
                patterns.Add("[Tt](oo|wo|o)", "Three");      // [Tt](oo|wo|o) -> Three
                patterns.Add("[Oo]ne|[Ww]on", "Two");        // [Oo]ne|[Ww]on -> Two
                patterns.Add("[Zz]ero", "One");              // [Zz]ero -> One

                foreach (KeyValuePair<string, string> pattern in patterns)
                {
                    input = Regex.Replace(input, pattern.Key, patterns[pattern.Key]);
                }

                return input;
            }
    }
}
