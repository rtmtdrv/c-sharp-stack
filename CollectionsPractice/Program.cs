using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays

            // Create an array to hold integer values 0 through 9
            int[] zeroThruNine = new int[10];
            for (int i = 0; i < 10; i++){
                zeroThruNine[i] = i;
            }

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] altTf = new bool[10];
            for (int i = 0; i < 10; i++){
                if (i % 2 == 0){
                    altTf[i] = true;
                } else {
                    altTf[i] = false;
                }
            }

            // List of Flavors

            //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>{
                "Mint Chip",
                "Oatmeal Raisin",
                "Vanilla Nut",
                "Chococlate Chip",
                "Cookie Dough",
            };
            //Output the length of this list after building it
            Console.WriteLine(flavors.Count);
            //Output the third flavor in the list, then remove this value
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            //Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(flavors.Count);

            // User Info Dictionary

            //Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> nameKeys = new Dictionary<string,string>();
            //Add key/value pairs to this dictionary where: (each key is a name from your names array, each value is a randomly select a flavor from your flavors list.)
            foreach (var name in names){
                nameKeys.Add(name, null);
            }
            Random rand = new Random();
            foreach (var name in names){
                int randIndex = rand.Next(flavors.Count - 1);
                nameKeys[name] = flavors[randIndex];
                flavors.RemoveAt(randIndex);
            }

            //Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (var entry in nameKeys){
                Console.WriteLine("{0}'s favorite flavor is {1}", entry.Key, entry.Value);
            }







        }
    }
}
