using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_final
{
    class Program
    {
        static void Main(string[] args)
        {

            RightTriangle a = new RightTriangle("#1 Object: ", 6, 8);
            a.Cal_area();
            a.Cal_perimeter();
            Console.WriteLine(a);

            Square b = new Square("#2 Object: ", 8);
            b.Cal_area();
            b.Cal_perimeter();
            Console.WriteLine(b);

            RightTriangle c = new RightTriangle("#3 Object: ", 5, 15);
            c.Cal_area();
            c.Cal_perimeter();
            Console.WriteLine(c);


            Square d = new Square("#4 Object: ", 7);
            d.Cal_area();
            d.Cal_perimeter();
            Console.WriteLine(d);

           


            GraphObject[] objects = new GraphObject[4] { a, b, c, d };
            Utilities.FindLargest(objects);

            Console.ReadKey();
        }
    }
}
