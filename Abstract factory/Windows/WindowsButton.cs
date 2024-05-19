using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_factory.Intefaces;

namespace Abstract_factory.Windows
{
    public class WindowsButton : IButton
    {
        public void HandleClick()
        {
            Console.WriteLine("Handle windows click event");
        }

        public void Render()
        {
            Console.WriteLine("Render windows button");
        }
    }
}
