using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ruscehproj2
{
    public static class HelpManager
    {
        public static ruscehproj2.helper hlp;

        static HelpManager()
        {
            hlp = new helper();
        }
    }

}