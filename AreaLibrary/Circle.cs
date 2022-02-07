using System;

namespace AreaLibrary
{
    public class Circle
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            this.Radius = r;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
