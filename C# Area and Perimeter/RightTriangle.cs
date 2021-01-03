using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_final
{

    class RightTriangle : GraphObject    // hihertance from parent class graphbjects
    {
        private int height;
        private int bas;

        public RightTriangle() : base()
        {
            height = 1;
            bas = 1;
        }

        public RightTriangle(string n, int h, int b) : base(n)
        {
            name = n;
            height = h;
            bas = b;
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Bas
        {
            get { return bas; }
            set { bas = value; }
        }

        public override double Cal_area()
        {
            area = bas * height / 2;          // claculating the area
            return area;
        }

        public override double Cal_perimeter()
        {
            perimeter = Math.Round(bas + height + Math.Sqrt(Math.Pow(bas, 2) + Math.Pow(height, 2)), 1);   // calucatuing the parmiter 
            return perimeter;
        }

        public override string ToString() 
        {
            return name + "A right triangle, height = " + height + ", base = " + bas + ", area = " + area + ", perimeter = " + perimeter;   // displaying the all the variables
        }

        ~RightTriangle() { }
    }
}