namespace HungryNinja
{
  class SweetTooth : Ninjas
  {
    public override bool isFull { get; set; }
    public override void Consume(IConsumable item)
    {
      if (isFull)
      {
        System.Console.WriteLine("SweetTooth is full and cannot consume anymore.");
      }
      else
      {
        if (caloriesIntake < 1500)
        {
          if (item.IsSweet)
          {
            caloriesIntake += (item.Calories + 10);
          }
          else
          {
            caloriesIntake += item.Calories;
          }
          FoodHistory.Add(item);
          item.GetInfo();
        }
        else
        {
          isFull = true;
        }

      }
    }
  }
}