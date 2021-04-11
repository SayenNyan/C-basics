using System;

namespace Lesson1HW5c
{
    //Соловьева Татьяна
/*Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
*Сделать задание, только вывод организовать в центре экрана.
*Задание со звездочкой в) **Сделать задание б с использованием собственных методов 
*(например, Print(string ms, int x,int y).*/
    class Program
    {
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition (x, y);
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            string msg = "Татьяна Соловьева, город Москва";
            Print(msg, (Console.WindowWidth / 2) - (msg.Length / 2), (Console.WindowHeight / 2) - 1);
       }
    }
}
