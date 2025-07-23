using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_opp01
{
    internal struct Point
    {
        public double X;
        public double Y;

        public Point (double x, double y)
        {
            X = x;
            Y = y;
        }

        public double distance(Point p)
        {
            double dx = p.X-X;
            double dy = p.Y-Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }


    }
}
