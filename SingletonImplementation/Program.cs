namespace SingletonImplementation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = SingletonDatabase.Instance;
            Console.WriteLine(db.GetPopulation("Tokyo"));
        }
    }
}