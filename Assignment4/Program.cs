namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PaymentCard card = new PaymentCard(10);
            Console.WriteLine(card.ToString());


            card.EatLunch();
            Console.WriteLine(card.ToString());


            card.DrinkCoffee();
            Console.WriteLine(card.ToString());

            card.AddMoney(5);
            Console.WriteLine(card.ToString());

            card.AddMoney(10000.0);
            Console.WriteLine(card.ToString());

            card.AddMoney(-10);
            Console.WriteLine(card.ToString());

        }
    }
}
