using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7Classes
{
    class Rectangle
    {
        private double length;
        private double width;
        private double area;

        public double Length
            {
                get
                {
                return length;
                }
                set 
                    {
                      length = value;
                CalculateArea();

                    }
            }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                CalculateArea();

            }
        }
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
             

            }
        }


        public Rectangle(double width, double length)
        {
            this.Length = length;
            this.Width = width;
        }

        private void CalculateArea()
        {
            Area = length * width;
            Console.WriteLine("Area is {0}", Area);
        }
    }
}
