using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
      public List<IConsumable> Menu;
      public Buffet()
      {
          Menu = new List<IConsumable>()
          {
                new Food("Lobster", 1000, false, false),
                new Food("Steak", 900, false, false),
                new Food("King Crab", 850, false,false),
                new Food("Spicy Chicken", 1000,true,false),
                new Food("Mashed Potatoes", 800,false,false),
                new Food("Baked Fish", 500,false,false),
                new Food("Steamed Vegitables", 200,false,false),
                new Drink("Soda", 500,false,true),
                new Drink("Water", 50,false,false),
                new Drink("tea", 500,false,false),
                new Drink("coffee", 500,false,false),
          };
      }
      public IConsumable Serve()
      {
          Random rand = new Random();
          return this.Menu[rand.Next(0, Menu.Count)];
      }
    }
}
