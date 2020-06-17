using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class Foodcreator
    {
        int ligt;
        int heit;
        char sym = '*';
        Random rand = new Random();
        public Foodcreator(int ligt , int heit, char sym)
        {
            this.heit = heit;
            this.ligt=ligt;
            this.sym=sym;
        }


        public Point Creadfood()
        {
            int x = rand.Next(2,heit);
            int y = rand.Next(2,ligt);
            return new Point(x,y,sym);
        }
    }



    }

