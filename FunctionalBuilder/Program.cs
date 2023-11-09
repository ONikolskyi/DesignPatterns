namespace FunctionalBuilder
{
    static class Program
    {
        public static void Main(string[] args)
        {
            var person = new PersonBuilder()
                .Called("Sara")
                .WorkAs("Developer")
                .Build();
            Console.WriteLine(person);
        }
    }
}