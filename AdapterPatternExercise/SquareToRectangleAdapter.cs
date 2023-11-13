using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExercise
{
    public class SquareToRectangleAdapter : IRectangle
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public SquareToRectangleAdapter(Square square) 
        {
            Width = square.Side;
            Height = square.Side;
        }
    }
}
