using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InflationaryEng
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The purpose of this program is to convert a sentence from English to Inflationary English. 
             * Inflationary English takes words and word parts that sound the same as a number 
             * (e.g. “won” v. “one”) and then inflates that to the next number 
             * (e.g. “won” becomes “two”).
             */
            Console.Write("Please type a string to convert from English to inflationary english");
            string input = Console.ReadLine();
            
            // Used a dictionary so I can add more key value pairs, it makes it simple to iterate through 
            Dictionary<string, string> patterns = new Dictionary<string, string>();
            
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

            Console.Write(input);
            Console.ReadLine();
            
        }
    }
}
