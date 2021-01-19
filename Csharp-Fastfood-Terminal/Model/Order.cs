namespace Csharp_Fastfood_Terminal.Model
{
    public class Order
    {
        public string Dish { get; private set; }

        public Order(string dish)
        {
            Dish = dish;
        }
    }
}