using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAdapter
{
    public class Button
    {
        private ICommand command;
        private string name;

        public Button(ICommand command, string name)
        {
            this.command = command;
            this.name = name;
        }

        public void Click()
        {
            command.Execute();
        }

        public void PrinetMe()
        {
            Console.WriteLine($"I am a button called {name}");
        }
    }
}
