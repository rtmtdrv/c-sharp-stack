using System.Collections.Generic;
namespace HungryNinja
{
    abstract class Ninjas
    {
        protected int caloriesIntake;
        public List<IConsumable> FoodHistory;

        public Ninjas(){
            this.caloriesIntake = 0;
            this.FoodHistory = new List<IConsumable>();
        }
        public abstract bool isFull{get;set;}
        public abstract void Consume(IConsumable item);
    }
}