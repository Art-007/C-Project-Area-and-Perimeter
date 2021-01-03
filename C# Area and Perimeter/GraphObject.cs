using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_final
{
 
        abstract class GraphObject : ICalculate   // interface class to find the area and paramiter, just like or in class activity 
        {
                         
            protected double area;              // protected members 
            protected double perimeter;
            protected string name;                 

        public GraphObject()
            {
                area = 0;
                perimeter = 0;
                 name = " ";
        }

        public GraphObject(string n)           
        {
                name = n;
        }

            public string Name            // setting name 
            {
                get { return name; }
                set { name = value; }
            }

            public double Area             // returing the area 
            {
                get { return area; }
                set { area = value; }
            }

            public double Perimeter            // returning the parameter 
            {
                get { return perimeter; }
                set { perimeter = value; }
            }

            public abstract double Cal_area();                   // abstact class to find the area 
            public abstract double Cal_perimeter();            // abstrac clas to find the parmiter 

            public override string ToString()
            {
                return "The area equals" + area + "  the perimeter equals" + perimeter;
            }
        ~GraphObject() { }
        }
    
}
