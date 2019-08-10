using System;

namespace Wizard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Tyler = new Human("Tyler");
            Wizard Art = new Wizard("Art");
            Ninja Jeff = new Ninja("Jeff");
            Samurai Todd = new Samurai("Todd");

            Jeff.Attack(Tyler);
            Tyler.getStats();
            Todd.Meditate();
            Todd.getStats();
            Art.Attack(Todd);
            Todd.getStats();
            Todd.Meditate();
            Todd.getStats();
        }
    }
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;

        public int Health 
        {
            get { return health; }
            set { health = value; }
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public virtual void getStats()
        {
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Strength: {Strength}");
            System.Console.WriteLine($"Intelligence: {Intelligence}");
            System.Console.WriteLine($"Dexterity: {Dexterity}");
            System.Console.WriteLine($"Health: {health}");
        }
    }
    class Wizard : Human 
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg =- 5;
            target.Intelligence += dmg;
            health += 5;
            System.Console.WriteLine($"{Name} lowered {target.Name} intelligence by {dmg} for {health} health!");
            return target.Intelligence;
        }

        public int Heal(Human target)
        {
            target.Health += 10;
            return target.Health;
        }

        public override void getStats()
        {
            base.getStats();
        }
    }

    class Ninja : Human 
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int luckyDmg = rand.Next(1,6);
            int dmg = -5;
            if(luckyDmg == 1)
            {
                target.Health -= 10;
                System.Console.WriteLine($"{Name} lowered {target.Name}'s health by 10!");
                return target.Health;
            }
            target.Dexterity += dmg;
            System.Console.WriteLine($"{Name} lowered {target.Name} dexterity by {dmg}!");
            return target.Dexterity;
        }

        public int steal(Human target)
        {
            target.Health -= 5;
            health += 5;
            
            return target.Health;
        }

        public override void getStats()
        {
            base.getStats();
        }
    }

    class Samurai : Human
    {
        public Samurai(string name) : base (name)
        {
            health = 200;
        }

        public int Meditate()
        {
            int backToLife = 200 - Health;
            Health += backToLife;
            return Health;
        }

        public override void getStats()
        {
            base.getStats();
        }
    }
}
