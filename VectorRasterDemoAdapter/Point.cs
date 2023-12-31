﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorRasterDemoAdapter
{
    public class Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;

            }
        }
    }
}
