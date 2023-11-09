namespace AsynchronousFactoryMethod
{
    public class Program
    {
        public static async void Main(string[] args)
        {
            Foo x = await Foo.CreateAsync();
        }
    }
}