using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shapes
    {
       // static double pie = 3.142;
        public int Area(int len,int brd)
        {
           return len * brd;
            
        }
        public double Area(double bas, double height)
        {

            return 0.5*bas*height;
   
        }

        public int Area(int side)
        {
           
            return side*side;
           
        }

        public double Area(double radius)
        {
            return 3.142*radius*radius;
        }



    }
}
