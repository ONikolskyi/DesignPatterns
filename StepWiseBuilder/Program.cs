using System.Text;

namespace StepWiseBuilder
{
    public class Demo
    {
        public static void Main(string[] arhs)
        {
            var car = CarBuilder.Create()   // ISpecifyCarType
                .OfType(CarType.Crossover)  // ISpecifyWheelSize
                .WithWheels(18)             // IBuildCar
                .Build();
            Console.WriteLine(car);
        }
    }
}