using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please type: (add/substract/exit)");
            string command;
            while((command = Console.ReadLine() ) != "exit")

{


int result;
if ( command == "add")
{
Console.WriteLine ("Enter first number to add:");
int firstNum = int.TryParse (Console.ReadLine());
Console.WriteLine ("Enter second number to add:");
int secondNum = int.TryParse (Console.ReadLine());
result = Addition(firstNum, secondNum);

}

else if ( command == "subtract")
{
Console.WriteLine ("Enter first number to add:");
int firstNum = int.TryParse (Console.ReadLine());
Console.WriteLine ("Enter second number to add:");
int secondNum = int.TryParse (Console.ReadLine());
result = Addition(firstNum, secondNum);

}
else 
{
Console.WriteLine("Invalid command");



}




{

static int Addition( int num1, int num2 );

}



{

return num1 + num2;

}

static int subtraction( int num1, int num2);

{

return num1 - num2;

}

        
static int collectIntfromuser()

{


bool error =  true;
while (error == true)

{

string uservalue = Console.ReadLine();
try

{

int intvalue = int.Parse(uservalue);
return intvalue;
error = false;

}


catch ( Exception exception ) {}


Console.WriteLine("invalid value entered. Please enter a number");

Console.WriteLine( exception.Message);


}


}

return intValue;

            } }
        
    
    
