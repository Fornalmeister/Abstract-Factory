using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_factory.Intefaces;

namespace Abstract_factory.Mac
{
    public class MacTextbox : ITextbox
    {
        public void HandleInput()
        {
            Console.WriteLine("Handle Mac textbox input");
        }

        public void Render()
        {
            Console.WriteLine("Render Mac textbox");
        }
    }
}
