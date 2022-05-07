using System;

namespace AreaLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            this.Radius = r;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
