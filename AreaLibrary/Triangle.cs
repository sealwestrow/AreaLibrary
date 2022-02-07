using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Triangle
    {
        private double[] _sides = new double[3];
        public double[] Sides 
        { 
            get
            {
                return _sides;
            }
            set 
            {
                for (int i = 0; i < 3; i++)
                {
                    if (value[i] < 0)
                    {
                        throw new ArgumentException("Сторона меньше нуля");
                    }
                    else
                    {
                        _sides[i] = value[i];
                    }
                }
            }
            
        }


        public Triangle(double[] sl)
        {
            Sides = sl;
            
        }
        public double GetArea()
        {
            double p = 0;
            foreach (var l in Sides)
            {
                p += l;
            }
            p /= 2;
            return Math.Sqrt(p * Math.Sqrt(p - Sides[0]) * Math.Sqrt(p - Sides[1]) * Math.Sqrt(p - Sides[2]));
        }

        public bool IsRight()
        {
            Array.Sort(Sides);
            double a = Sides[0];
            double b = Sides[1];
            double c = Sides[2];
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }
    }
}
