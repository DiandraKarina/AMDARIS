using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ButtonFactory
    {
        public static Button CreateButton()
        {
            return new Button { Type = "Continue Reading Button"};
        }
    }
}
