using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
     class Zmeika : Line
    {
        
     public    Napravlenie n1;                 // Сохранение направление

         public Zmeika(Point kon, int lengt, Napravlenie n)       // Функция для увелечение змейки  передаем конец змейки, длину и направление движения
         {
             n1 = n;                                                        //  задаем новое направление 
 
             plist = new List<Point>();                                     //  Создаем список где хранится точки змейки

             for (int i = 0; i < lengt; i++)
             {
                 Point p = new Point(kon);                             //  Передаем змеку состоящию из точек 
                 p.mov(i, n);                                   //  Смещаем точки змейки на  1  в заданном направлении
                 plist.Add(p);                                   // добавляем в список новые координаты змейки

             }
         }
/// //////////////////////////////////////////////////////////////////
/// Удаляем последний элемент
/// добавляем новый элемент и выводим на экран
        internal void mov()
        {
            Point kon = plist.First();
            plist.Remove(kon);
            Point head = GetNextPoint();
            plist.Add(head);

            kon.Clear(); 
           head.Draw(); 
        }
 
/// //////////////////////////////////////////////////////////
// Узнаем следующую точку
        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextpoint = new Point(head);
            nextpoint.mov(1, n1);
 
            return nextpoint;
        }
 
/// //////////////////////////////////////////////////////
 
         public bool prov ()
        {
             for (int i =0; i<plist.Count-1; i++)
             {
                 Point head = plist.Last();
                  
                 
                 if (head.y == plist[i].y && head.x==plist[i].x)
                 {
                     return false;
                 }  

                 for (int j= 0; j <24; j++)
                 {
                 if (head.y==j && head.x==78 || head.y==j && head.x==1)
                 { return false; }

                     for(int a =0; a<79; a++)
                     {
                         if (head.y==0 && head.x==a || head.y==23 && head.x==a)
                         { return false ;}
                     }
                 }

             }

            return true;
        }
 
/// ///////////////////////////////////////////////////////////////////////////////
// Проверка на совпадения головы и точки на экране
         public int b = 0;

        public bool Eat(Point food1)
        {
            Point head = GetNextPoint();
            if (head.x == food1.x && head.y == food1.y)
            {
                b++;
                drow1();
                plist.Add(food1);
                return true;
            }
            else return false;
        }

        public void drow1()
        {
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("ВАШ СЧЕТ    " + b + " ");
        }

/// ////////////////////////////////////////////////////////////////////////////
 //Поверка нажатых кнопок
         public void hand (ConsoleKey key)
        {
            if (n1 == Napravlenie.vlevo && key == ConsoleKey.RightArrow)
            { key = ConsoleKey.LeftArrow; }

            if (n1 == Napravlenie.vpravo && key == ConsoleKey.LeftArrow)
            { key = ConsoleKey.RightArrow; }

            if (n1 == Napravlenie.vniz && key == ConsoleKey.UpArrow)
            { key = ConsoleKey.DownArrow; }

             if (n1 == Napravlenie.vverx && key == ConsoleKey.DownArrow)
             { key = ConsoleKey.UpArrow; }



            if (key == ConsoleKey.LeftArrow)
                 n1 = Napravlenie.vlevo;
            if (key == ConsoleKey.RightArrow)
                 n1 = Napravlenie.vpravo;
            if (key == ConsoleKey.DownArrow)
                 n1 = Napravlenie.vniz;
            if (key == ConsoleKey.UpArrow)
                 n1 = Napravlenie.vverx;



           

        }

 
         public bool zzz(ConsoleKey key)
         {
              

             if (key == ConsoleKey.Escape)
             { 
                 Console.SetCursorPosition(25, 12);
                 Console.WriteLine("Продолжить");

                 Console.SetCursorPosition(21, 12);
                 string st = "-->";
                 Console.WriteLine(st);

                 Console.SetCursorPosition(25, 11);
                 Console.WriteLine("Выход");

                  
                 if (key == ConsoleKey.UpArrow)
                 {
 
                      
                     Console.SetCursorPosition(21, 13);
                     Console.WriteLine("wedwef");
                 }
                  
                 return false;
                  
             }
             return true;
        
         }

    }
}
