using System;

namespace HW5a
{
    // Соловьева Татьяна
/*а) Написать программу, которая выводит на экран ваше имя, 
 * фамилию и город проживания.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите город проживания: ");
            string city = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"{name} {surname}, город {city}");
        }
    }
}
