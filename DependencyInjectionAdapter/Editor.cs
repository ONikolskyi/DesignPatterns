using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAdapter
{
    public class Editor
    {
        private IEnumerable<Button> buttons;

        public Editor(IEnumerable<Button> buttons)
        {
            this.buttons = buttons;
        }

        public IEnumerable<Button> Buttons { get => buttons; }

        public void ClickAll()
        {
            foreach(var button in buttons)
            {
                button.Click();
            }
        }
    }
}
