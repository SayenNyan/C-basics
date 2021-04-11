using System;

namespace HW2
{
    //Соловьева Татьяна
/*Ввести вес и рост человека. 
 * Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
 * где m — масса тела в килограммах, h — рост в метрах.*/
    class Program
    {
        static void Main(string[] args)
        {
            double m;
            double h;
            Console.WriteLine("Расчет индекса массы тела (ИМТ)");
            Console.Write("Введите ваш вес в килограммах: ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш рост в метрах: ");
            h = Convert.ToDouble(Console.ReadLine());
            double I = m / (h * h);
            Console.WriteLine("Ваш ИМТ: " + Math.Round(I, 2));
        }
    }
}
