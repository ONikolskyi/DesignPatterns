namespace CopyThroughSerialization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var john = new Person(new[] { "John", "Doe" },
                new Address
                {
                    HouseNumber = 123,
                    StreetName = "London Road"
                });

            var jane = john.DeepCopyXml();

            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 321;

            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}