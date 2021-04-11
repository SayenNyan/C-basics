using System;

namespace HW3a
{
    //Соловьева Татьяна
/*а) Написать программу, которая подсчитывает расстояние между точками 
 * с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
 * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);*/
    class Program
    {
        static void Main(string[] args)
        {
            //подставление внутри кода
            //double x1 = 0;
            //double y1 = 0;
            //double x2 = 0;
            //double y2 = 1;

            //double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));  //Math.Pow(double, double) - возведение в степень
            //Console.WriteLine("{0:N}", r);                                      //"{0:N}" - формативание, вывод 2 знаков после запятой


            //запрос ввода через консоль
            double x1;
            double y1;
            double x2;
            double y2;
            
            Console.WriteLine("Расчет расстояния между точками в двумерной системе координат");
            Console.WriteLine("Введите координаты точки 1:");
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки 2:");
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToDouble(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками: {0:N}", r);
        }
    }
}
