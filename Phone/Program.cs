using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8",100,"T-mobile","Dooo do doo dooo");
            Nokia elvenHundred = new Nokia("1100",60,"Metro PCS", "Ringgg ring ringgg");

            s8.DisplayInfo();
            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlocked());
            System.Console.WriteLine("");

            elvenHundred.DisplayInfo();
            System.Console.WriteLine(elvenHundred.Ring());
            System.Console.WriteLine(elvenHundred.Unlocked());
            System.Console.WriteLine("");
        }
    }
}