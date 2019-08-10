namespace HungryNinja
{
  class SpiceHound : Ninjas
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
          if (caloriesIntake < 1200){
              if(item.IsSpicy){
                  caloriesIntake += (item.Calories - 5);
              }else{
                  caloriesIntake += item.Calories;
              }
              FoodHistory.Add(item);
              item.GetInfo();
          }else{
              isFull = true;
          }
      }
    }
  }
}