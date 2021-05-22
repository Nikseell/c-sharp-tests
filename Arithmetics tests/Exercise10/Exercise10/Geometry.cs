using System;

namespace Exercise10
{
    public class Geometry
    {
        public double AreaOfCircle(decimal radius)
        {
            if (radius <= 0)
            {
                return 0;
            }
            else
            {
                return Math.Round((Math.PI * Math.Pow((double)radius, 2.0)), 2);
            }
        }

        public double AreaOfRectangle(decimal length, decimal width)
        {
            if (length <= 0 || width <= 0)
            {
                return 0;
            }
            else
            {
                return (double)(length * width);
            }
        }

        public double AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground <= 0 || h <= 0)
            {
                return 0;
            }
            else
            {
                return (double)(ground * h) / 2;
            }
        }
    }
}
