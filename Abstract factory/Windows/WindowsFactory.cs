﻿using Abstract_factory.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory.Windows
{
    public class WindowsFactory : IUIElementFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextbox CreateTextBox()
        {
            return new WindowsTextbox();
        }
    }
}
