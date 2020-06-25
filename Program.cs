using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int mynum = 3;
        while (mynum > 0) //Itreates loops while the condition is true.

        {
            Console.WriteLine ("current number is {0}", mynum );
            mynum--;

        }
/* for loop have e semi colon separted componets;
1. Assignment
2. termination condition
3. Iteration

*/
for (int i= 0; i < 6; i+=2 )
{

    Console.WriteLine ("cureent for number is: {0}", i);
}

string [] mylist = {"cat", "turtle", "lizard", "frog", "dog" };
foreach ( string listitem in mylist )

{
    Console.WriteLine ("The current item is: {0},", listitem );
}




}
         
        }
    }


