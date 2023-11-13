using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExercise
{
    public static class ExtensionMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Height * rc.Width;
        }
    }
}
