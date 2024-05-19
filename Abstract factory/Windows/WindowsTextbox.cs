using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_factory.Intefaces;

namespace Abstract_factory.Windows
{
    public class WindowsTextbox : ITextbox
    {
        public void HandleInput()
        {
            Console.WriteLine("Handle windows textbox input");
        }

        public void Render()
        {
            Console.WriteLine("Render windows textbox");
        }
    }
}
