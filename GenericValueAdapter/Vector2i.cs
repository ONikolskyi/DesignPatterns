using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericValueAdapter
{
    public class Vector2i
        : VectorOfInt<Dimensions.Two>
    {
        public Vector2i()
        {
        }

        public Vector2i(params int[] values) : base(values)
        {
        }
    }
}
