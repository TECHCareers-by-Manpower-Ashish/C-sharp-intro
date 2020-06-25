using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
           

Console.WriteLine ("Enter a number");
int userint = int.Parse(Console.ReadLine ());
if (userint >5)

{

    Console.WriteLine("greater than 5");

}
else if (userint > 10 )

{
Console.WriteLine ("A negative number");

}

else if (userint <0)

{
Console.WriteLine ("A negative number");

}

else
{Console.WriteLine("Number is between 0 and 5");


}






}
         
        }
    }


