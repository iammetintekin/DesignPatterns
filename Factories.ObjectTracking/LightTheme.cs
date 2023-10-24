using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.ObjectTracking
{
    public class LightTheme:ITheme
    {
        public string TextColor => "black";

        public string BgColor => "white";
    }
}
