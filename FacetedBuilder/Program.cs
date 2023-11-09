namespace FacetedBuilder
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Works.At("Luxoft")
                    .AsA("Developer")
                    .Earning(1000)
                .Lives.At("Central Park st.")
                    .In("Dnipro")
                    .WithPostcode("49008");

            Console.WriteLine(person);
        }
    }
}