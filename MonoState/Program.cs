namespace MonoState
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ceo = new CEO();
            ceo.Name = "Adam Smith";
            ceo.Age = 55;

            var ceo2 = new CEO();

            Console.WriteLine(ceo);
            Console.WriteLine(ceo2);
        }
    }
}