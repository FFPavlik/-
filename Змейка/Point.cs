using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
   class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point() { }
        public Point(int x, int y, char sym)                   //Для отображения боковых линий
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

       public Point (Point p)      //  для отображения змеки
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

       public void mov (int of, Napravlenie n)
       {
           if (n == Napravlenie.vpravo)
               x = x + of;
           else if (n == Napravlenie.vlevo)
               x = x - of;
          else if (n == Napravlenie.vverx)
               y = y - of;
           else if (n == Napravlenie.vniz)
               y = y + of;
       }

        
       public void Draw()   // вывод линий 
        {
           try
           {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
           }
           catch(Exception)
           {}

        }

       internal void Clear()
       {
            sym= ' ';
           Draw();
       }
      
    }
}
