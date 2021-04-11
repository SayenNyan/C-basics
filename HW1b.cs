using System;

namespace HW1b
{
    // Соловьева Татьяна
    /* Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
     * В результате вся информация выводится в одну строчку:
     * б) используя форматированный вывод; */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анкета");
            Console.WriteLine("Заполните данные о себе.");
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Возраст: ");
            string age = Console.ReadLine();
            Console.Write("Рост в см: ");
            string h = Console.ReadLine();
            Console.Write("Вес в кг: ");
            string w = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("{0} {1}: {2} лет, {3} см, {4} кг", name, surname, age, h, w);
        }
    }
}
