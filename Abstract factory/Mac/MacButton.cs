using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_factory.Intefaces;

namespace Abstract_factory.Mac
{
    public class MacButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Handle Mac click event");
        }

        public void Render()
        {
            Console.WriteLine("Render Mac button");
        }
    }
}
