using System;

namespace HW5b
{
    //Соловьева Татьяна
 /*Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 * Задание со звезочкой б) *Сделать задание, только вывод организовать в центре экрана.*/

    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 1: с готовой инфо
            string text = "Татьяна Соловьева, город Москва";
            int x = (Console.WindowWidth / 2) - (text.Length / 2);
            int y = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);



            // Вариант 2: с запросом инфо у пользователя
            //Console.Write("Введите имя: ");
            //string name = Console.ReadLine();
            //Console.Write("Введите фамилию: ");
            //string surname = Console.ReadLine();
            //Console.Write("Введите город проживания: ");
            //string city = Console.ReadLine();

            //Console.Clear();
            //string text = $"{name} {surname}, город {city}";
            //int x = (Console.WindowWidth / 2) - (text.Length / 2);
            //int y = (Console.WindowHeight / 2) - 1;
            //Console.SetCursorPosition(x, y);
            //Console.WriteLine(text);
        }
    }
}
