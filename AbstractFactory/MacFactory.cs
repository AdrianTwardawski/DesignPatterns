using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacFactory : IUIElementFactory
    {
        public IButton createButton()
        {
            return new MacButton();
        }

        public ITextbox createTextbox()
        {
            return new MacTextbox();
        }
    }
}
