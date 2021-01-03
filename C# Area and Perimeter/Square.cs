using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_final
{
    class Square : GraphObject
    {
        private int segment;

        public Square() : base()
        {
            segment = 1;
        }

        public Square(string n, int s) : base(n)
        {
            name = n;
            segment = s;
        }

        public Square(int s)
        {
            segment = s;
        }

        public int Segment
        {
            get { return segment; }
            set { segment = value; }
        }

        public override double Cal_area()
        {
            area = Math.Pow(segment, 2);
            return area;
        }

        public override double Cal_perimeter()
        {
            perimeter = segment * 4;
            return perimeter;
        }

        public override string ToString()
        {
            return name + "A square, segment = " + segment + ", area = " + area + ", perimeter = " + perimeter;
        }

        ~Square() { }
    }
}