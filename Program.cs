using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
        

        // 2 dimenson array!
        
string[,] topics = {{"cats", "dog", "dog", "hedgehog" },

                    {"zebra","gifaffe","lion", "elephant"},
                     {"dolphine", "octopus", "shark", "whale"},
                     {"bug","beetle","waterbug", "mosquito"}};     

            for( int row = 0; row < topics.GetLength(0); row++ )
            {
                // Output current row...
                Console.WriteLine( "Starting row #{0}", row );
                // Loop through columns in the current row...
                for ( int column = 0; column < topics.GetLength(1); column++ )
                {
                    // Output the current column...
                    Console.WriteLine( "Starting column #{0}", column );
                    // Output the current animal!
                    Console.WriteLine( "This animal is: {0}", topics[row,column] );
                }
            }
        }
    }
}