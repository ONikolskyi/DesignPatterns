using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class HotDrinkMachine
    {
        //public enum AvailableDrink
        //{
        //    Coffee,
        //    Tea
        //}

        //private Dictionary<AvailableDrink, IHotDrinkFactory> factories =
        //    new Dictionary<AvailableDrink, IHotDrinkFactory> ();

        //public HotDrinkMachine()
        //{
        //    foreach(AvailableDrink drink in Enum.GetValues (typeof (AvailableDrink)))
        //    {
        //        var factory = Activator.CreateInstance(
        //            Type.GetType($"AbstractFactory.{Enum.GetName(typeof(AvailableDrink), drink)}Factory")
        //            ) as IHotDrinkFactory;
        //        factories.Add(drink, factory);
        //    }
        //}

        //public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        //{
        //    return factories[drink].Prepare(amount);
        //}

        // factory which following the OCP
        private List<Tuple<string, IHotDrinkFactory>> _factories = 
            new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachine()
        {
            foreach(var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if(typeof(IHotDrinkFactory).IsAssignableFrom(t) && 
                    !t.IsInterface)
                {
                    _factories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t)));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks:");
            for (int index = 0; index < _factories.Count; index++)
            {
                Tuple<string, IHotDrinkFactory> tuple = _factories[index];
                Console.WriteLine($"{index}: {tuple.Item1}");
            }

            while (true)
            {
                string s;
                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out int i)
                    && i >= 0
                    && i < _factories.Count)
                {
                    Console.Write("Specify amount: ");
                    s = Console.ReadLine();
                    if (s != null && int.TryParse(s, out int amount) && amount > 0)
                    {
                        return _factories[i].Item2.Prepare(amount);
                    }
                }
                Console.WriteLine("Incorrect input, try again!");
            }
        }
    }
}
