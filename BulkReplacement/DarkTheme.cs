using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkReplacement
{
    internal class DarkTheme : ITheme
    {
        public string TextColor => "white";

        public string BgrColor => "dark grey";
    }
}
