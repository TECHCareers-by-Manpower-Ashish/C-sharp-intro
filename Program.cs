using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two slashes mark the beginning of single-line comment.
           //we are assigning a string value to variable.
            string myname = "Ashish Patel";
        /* we begn multi-line comments with a forward-slash and asterrisk....


        symbols between values or evaluations are considered "operations ."
        below we are using the addition symbol to concatenate two strings.
        (concatenation means gluing two strigs, or texts, together.gi)

https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netcore-3.1
        ... and we end multi-line comments with an asterisk followed by a forward-slash*/

            Console.WriteLine("Hello," + myname );
            Console.WriteLine ("Please enter your name");

            //Assign variable username to a value entered by the user.
            https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=netcore-3.1
            string username = Console.ReadLine();
            Console.WriteLine("you have entered:   " + username);


            //Instead of traditional concatenation using the addition operater..
            //we can use string interpolation (placeholder) to embed values in
        
           Console.WriteLine("Hey {0}, you are looking greate today!", username);
           Console.WriteLine ("Makemeuppercase".ToUpper() );
           Console.WriteLine("Makemeloverscase".ToLower() );
           //substring takes two arguments: 1) starting character postion 2) number of charcheter to collect.
           Console.WriteLine("ABCDEFGHIGKLMANOPQRSTUVWXYZ".Substring (4, 6));
           Console.WriteLine("XYZ".Length);//get the number of character for the string.
           


        }
    }
}
