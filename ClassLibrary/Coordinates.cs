using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates()
        {
            X = 5;
            Y = 5;
        }
        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
