using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {

        // Create an empty list of type object
        List<object> boxList = new List<object>();

        //Add values: 7, 28, -1, true, "chair"
        boxList.Add(7);
        boxList.Add(28);
        boxList.Add(-1);
        boxList.Add(true);
        boxList.Add("chair");

        // Loop through the list and print all values (Hint: Type Inference might help here!)
        foreach (var item in boxList){
            Console.WriteLine(item);
        }

        //Add all values that are Int type together and output the sum
        int sum = 0;
        foreach (var item in boxList){
            if (item is int){
                sum += (int)item;
            }
        }

        Console.WriteLine(sum);


        }


    }
}
