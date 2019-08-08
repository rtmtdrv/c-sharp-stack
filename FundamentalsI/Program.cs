using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================");

            // LOOP THAT PRINTS VALUES 1-255
            for(int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }

            Console.WriteLine("================================");

            // LOOP THAT PRINTS ALL VALUES FROM 1-100 THAT DIVISIBLE BY 3 OR 5, BUT NOT BOTH
            for (int i = 1; i <= 100; i++){
                if(i % 15 == 0){
                    continue;
                }
                else if (i % 3 == 0 || i % 5 == 0 ) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("================================");

            // LOOP THAT PRINTS "FIZZ" FOR MULTIPLES OF 3, "BUZZ" FOR MULTIPLES OF 5, AND "FIZZBUZZ" FOR NUMBERS THAT ARE MULTIPLES OF BOTH 3 AND 5

            for (int i = 1; i <= 100; i++){
                if(i % 3 == 0){
                    if(i % 5 == 0){
                        Console.WriteLine("FizzBuzz");
                    }
                    else {
                        Console.WriteLine("Fizz");
                    }
                }
                else if (i % 5 == 0 ) {
                    Console.WriteLine("Buzz");
                }
            }

            Console.WriteLine("================================");
            
        }

        

    }
}
