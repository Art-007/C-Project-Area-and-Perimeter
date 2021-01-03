using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_final
{

    class Utilities
    {
        public static void FindLargest(GraphObject[] z)
        {
            double largeestArea = 0;
            int x = 0;
            double largeestPerimeter = 0;
            int y = 0;

            for (int i = 0; i < 4; i++)                 // finding the largest area of 4 objects 
            {
                if (z[i].Area > largeestArea)
                {
                    largeestArea = z[i].Area;
                    x = i;
                }

                if (z[i].Perimeter > largeestPerimeter)           // finding the largest parmiter of 4 objects 
                {
                    largeestPerimeter = z[i].Perimeter;
                    y = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine(z[x].Name + "has the largest area of " + z[x].Area);             // displaying the largest area 
            Console.WriteLine(z[y].Name + "has the largest perimeter of " + z[y].Perimeter);   // displaying the largest paremter 
        }
    }
}