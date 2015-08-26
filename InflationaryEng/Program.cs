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
             * 
             * The description of the program was a little vague
             * Not sure if the user will input a list of words or if the 
             * list will grow at any given timme for the convertion portion. It 
             * also doesn't describe what type of project is required
             * therefore I made it into a simple console project for training
             * purposes.
             * 
             * Unit testing is included in this project to test at a later 
             * time or if changes are made.
             * 
             * 
             */
            Console.WriteLine("Please type a string to convert from English to inflationary english\n");
            string input = Console.ReadLine();

            // Creating class object to convert input sentense
            ConvertWords converter = new ConvertWords();

            // using a new string to check the difference between the original string and the new string
            string output = converter.ConvertInput(input);

            // 
            Console.WriteLine("\nHere is the output string: \n\n" + output);
            Console.ReadLine();
            
        }
    }
}
