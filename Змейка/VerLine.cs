using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
 class VerLine : Line // рисовка вертикальных линей
    {
          
        public VerLine (int py , int ly, int x , char sym) // передаем длину линии от ру до ly , кординату Х и символ , который хотим нарисовать
        {
            plist = new List<Point>();                     //  создаем список который будет хранить точки нашей линии
               for (int y = py; y<ly;   y++)
            {
                Point p = new Point(x, y, sym);           //  в цикле добавляем в список точки линии 
                plist.Add(p);
            }

        }



    }
}
