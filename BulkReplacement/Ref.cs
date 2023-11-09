using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkReplacement
{
    internal class Ref<T> where T : class
    {
        public T Value;

        public Ref (T value)
        {
            Value = value;
        }
    }
}
