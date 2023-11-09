namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink();
        }
    }
}