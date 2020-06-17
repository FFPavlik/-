using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class GorLine : Line
    {
        
        public GorLine (int px , int lx, int y , char sym) 
        {
            plist = new List<Point>();
               for (int x = px; x<lx;   x++)
            {
                Point p = new Point(x, y, sym);

                plist.Add(p);
            }

        }
 




    }
}
