using Abstract_factory.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory.Mac
{
    public class MacFactory : IUIElementFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextbox CreateTextBox()
        {
            return new MacTextbox();
        }
    }
}
