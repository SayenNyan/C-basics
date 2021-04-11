using System;

namespace HW4b
{
    //Соловьева Татьяна
/*Написать программу обмена значениями двух переменных:
* Задание со звездочкой б) *без использования третьей переменной. */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение переменной a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"a = {a}, b = {b}");

            //b = b + a;                  // Вариант 1: показано на уроке - через сложение/вычитание
            //a = b - a;
            //b = b - a;

            //a = a + b - (b = a);        // Вариант 2: краткая запись алгоритма выше

            a = a * b;                  // Вариант 3: через умножение/деление
            b = a / b;
            a = a / b;

            //a = a - b;                  // Вариант 4: через вычитание/сложение
            //b = a + b;
            //a = -a + b;

            // Вариант 5: через битовые манипуляции.
            // Например, a=5, b=2 => a=101, b=010 в двоичной системе счисления
            //Console.Write("Введите значение переменной a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите значение переменной b: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"a = {a}, b = {b}");

            //a = a ^ b;                  // a = 101^010 = 111
            //b = a ^ b;                  // b = 111^010 = 101
            //a = a ^ b;                  // a = 111^101 = 010

            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
