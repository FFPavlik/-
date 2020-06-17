using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class Line
    {

       public  List<Point> plist;
 
       public void drow ()
        {
             
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }




    }
}
