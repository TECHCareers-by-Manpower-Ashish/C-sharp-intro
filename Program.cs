using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            //logical operator 

            //Or will evaluate to true if eigher side is true.
            Console.WriteLine (true || true); // || is OR
            Console.WriteLine (false || true); // True
            Console.WriteLine (false || false); // True


            // And  will evaluate to true only if boith sides are true 
            Console.WriteLine (true && true); //trye. // && is and 
            Console.WriteLine (false && true); // false.
             Console.WriteLine (false && false); // false.
            


        // how does this behave with different datatype
        //Console.WriteLine (false || true); it's doesnot allow

        //comparitive operators
        // "equal to check.
        Console.WriteLine (false == false );// True
        Console.WriteLine (true == false );// false
        Console.WriteLine (2.25==2.25);// trrue
        Console.WriteLine (2.25 == 3.25);// false
        //Console.WriteLine (3.14 =="3.14"); //cannot check tow different types.



        // greater than check

        Console.WriteLine (6>7);//false

        Console.WriteLine (10>5);


        // less than check

        Console.WriteLine (6<7);//true
        Console.WriteLine (10<5);//false


        //greater than or equal to check
        Console.WriteLine (5>=5);//true
        Console.WriteLine (10>=5);//true
        Console.WriteLine (4>=5);//false


        //less than or equal to check
        Console.WriteLine (5<=5);//true
        Console.WriteLine (10<=5);//false
        Console.WriteLine (4<=5);//true


        //Not equal to check
        Console.WriteLine ( false != false ); //false
        Console.WriteLine ( true != false ); //true
        Console.WriteLine ( 5 != 5 ); //false
        Console.WriteLine ( 5 != 10 ); //true
        






        }
    }
}
