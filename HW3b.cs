﻿using System;

namespace Lesson1._HW3b
{
    //Соловьева Татьяна
/*Написать программу, которая подсчитывает расстояние между точками 
 * с координатами x1, y1 и x2,y2 по формуле 
 * r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
 * Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
 * 
 * Задание со звездочкой б) Выполнить предыдущее задание, оформив вычисления 
 * расстояния между точками в виде метода.*/
     class Program
     {
         
        static double R(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        
        static void Main(string[] args)
         {
            Console.WriteLine("Расчет расстояния между точками в двумерной системе координат");
            Console.WriteLine("Введите координаты точки 1:");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите координаты точки 2:");
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Расстояние между точками:{0:N}", R(x1, y1, x2, y2));
        }
     }
}
