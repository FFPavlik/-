using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Змейка
{
    class Program
    {
         
        static void Main(string[] args)
        {
             
         
            GorLine g = new GorLine(1,79,0,'*');
            g.drow();

            GorLine g1 = new GorLine(1, 79, 23, '*');
            g1.drow();

            VerLine v = new VerLine( 1,24, 1 , '*');
            v.drow();
            VerLine v1 = new VerLine(1, 24, 78, '*');
            v1.drow();


            Console.SetCursorPosition(27, 10);
            Console.WriteLine("Для старта нажмите ENTER");

            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                Console.Clear();
                g.drow();
                g1.drow();
                v.drow();
                v1.drow();
  

                // Х  //У
                Point p = new Point(25, 10, '*');
                Zmeika zmeika = new Zmeika(p, 4, Napravlenie.vverx);
                zmeika.drow();

                zmeika.drow1();

                Foodcreator food = new Foodcreator(22, 77, '*');
               
                Point food1 = food.Creadfood();
                food1.Draw();

             bool a = true;




                while (a)
                {


                    //if (Console.KeyAvailable)
                    //{
                    //    ConsoleKeyInfo keys = Console.ReadKey();

                    //    if (zmeika.zzz(keys.Key) == false)
                    //    { Thread.Sleep(5000); }

                    //}





                    if (zmeika.prov() == false)
                    {
                        a = false;
                        Console.SetCursorPosition(35, 10);
                        Console.WriteLine("GAME OVER");

                    }

                    if (zmeika.Eat(food1))
                    {
                        food1 = food.Creadfood();
                        food1.Draw();
                    }
                    else
                    {
                        zmeika.mov();
                    }


                    Thread.Sleep(100);


                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        zmeika.hand(key.Key);
                    }

                }





            }//gfbf



                Console.Read();
        }
 

    }
}