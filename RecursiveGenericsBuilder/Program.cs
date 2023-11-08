namespace RecursiveGenericsBuilder
{
    public class Program
    {
        public static void Main(string[] arhs)
        {
            var person = Person.New.Called("Oleksii").WorksAsA("QA").Build();
            Console.WriteLine(person);
        }
    }
}