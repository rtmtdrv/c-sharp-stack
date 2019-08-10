using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet lux = new Buffet();
            SweetTooth jack = new SweetTooth();
            SpiceHound john = new SpiceHound();

            jack.Consume(lux.Serve());
            System.Console.WriteLine(jack.isFull);

            jack.Consume(lux.Serve());
            System.Console.WriteLine(jack.isFull);

            john.Consume(lux.Serve());
            System.Console.WriteLine(john.isFull);
            john.Consume(lux.Serve());
            System.Console.WriteLine(john.isFull);
            john.Consume(lux.Serve());
            System.Console.WriteLine(john.isFull);

            if(jack.FoodHistory.Count > john.FoodHistory.Count){
                foreach(IConsumable eat in jack.FoodHistory){
                    System.Console.WriteLine(eat);
                }
            } else {
                foreach(IConsumable eat in john.FoodHistory){
                    System.Console.WriteLine(eat.Name);
                }
            }
        }
    }
}