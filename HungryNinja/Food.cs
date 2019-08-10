namespace HungryNinja
{
  public class Food : IConsumable
  {
    public string Name { get; set; }
    public int Calories { get; set; }
    public bool IsSpicy { get; set; }
    public bool IsSweet { get; set; }

    public Food(string name, int calories, bool isSpicy, bool isSweet)
    {
      this.Name = name;
      this.Calories = calories;
      this.IsSpicy = isSpicy;
      this.IsSweet = isSweet;
    }
    public string GetInfo()
    {
      return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
    }
  }
}