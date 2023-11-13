using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAdapter
{
    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Saving a file");
        }
    }
}
