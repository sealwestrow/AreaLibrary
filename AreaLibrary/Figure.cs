using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaLibrary
{
    public abstract class Figure
    {
        private double[] _sides;

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


        public abstract double GetArea();
        
    }
}
