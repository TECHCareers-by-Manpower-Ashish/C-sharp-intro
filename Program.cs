using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //"=" is the assignment operator
            //String datatype is used for text.
        
            String mystring = "This is a string!";
            int myint = 42;

            Double myDouble = 33.666;

            bool mybool = true;

            //subtraction operator is "-" (minus)
            Console.WriteLine (myint - 10); //32

            //multicplication operaton is "*" 

            Console.WriteLine (myint * 2);


            //Divison operator 
            Console.WriteLine(myint / 2); //21

            //Modulus operator is "%"
            Console.WriteLine(myint % 13);

            //Addition operator is "+"

            Console.WriteLine(myint + 8); //8

            Console.WriteLine( "3" + "3");
            Console.WriteLine( "3" + 3);
            Console.WriteLine(3 + 6 + "3");

        }
    }
}
