using System;

namespace HW4a
{
    //Соловьева Татьяна
/*Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;*/
    class Program
    {
        static void Main(string[] args)
        {
            // через double - позволяет ввод чисел со знаками после запятой
            Console.Write("Введите значение переменной a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"a = {a}, b = {b}");

            double temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a = {a}, b = {b}");

            //через int - только целочисленные значения
            //Console.Write("Введите значение переменной a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите значение переменной b: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"a = {a}, b = {b}");
            //int temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
