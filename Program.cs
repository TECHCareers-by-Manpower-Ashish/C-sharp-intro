using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine ("please tell us if you want to add or subtreact:(add/Subtract)");
           string useroparator = Console.ReadLine();
           if  (useroparator =="add")
           Console.WriteLine ("please enter the first number:");
           int firstNum = Int32.Parse(Console.ReadLine () );
           Console.WriteLine("please enter the second number to add");
           int secondNum = Int32.Parse(Console.ReadLine() );


            int result = firstNum + secondNum ;
            Console.WriteLine ("{0} + {1} = {2}", firstNum, secondNum, result  );

            else if (useroparator == "subtract")


{

           
   
           Console.WriteLine ("please enter the first number:");
           int firstNum = Int32.Parse(Console.ReadLine () );
           Console.WriteLine("please enter the second number to subtract");
           int secondNum = Int32.Parse(Console.ReadLine() );


            int result = firstNum - secondNum ;
            Console.WriteLine ("{0} -  {1} = {2}", firstNum, secondNum, result  );


}

}
         
        }
    }


