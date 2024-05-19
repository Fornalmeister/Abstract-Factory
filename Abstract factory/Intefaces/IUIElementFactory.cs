using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory.Intefaces
{
    public interface IUIElementFactory
    {
        IButton CreateButton();
        ITextbox CreateTextBox();
    }
}
