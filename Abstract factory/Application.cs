using Abstract_factory.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_factory
{
    public class Application
    {
        private IUIElementFactory _elementFactory;

        public Application(IUIElementFactory elementFactory)
        {
            _elementFactory = elementFactory;
        }

        public void RenderUI()
        {
            var createNewFileButton = _elementFactory.CreateButton();
        
            createNewFileButton.Render();

            var textbox = _elementFactory.CreateTextBox();

            textbox.Render();
        }
    }
}
