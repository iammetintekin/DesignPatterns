using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.ObjectTracking
{
    public class DarkTheme : ITheme
    {
        public string TextColor => "white";

        public string BgColor => "black";
    }
}
