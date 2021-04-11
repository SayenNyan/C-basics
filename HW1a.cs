using System;

namespace HW1a
{
    // Соловьева Татьяна
    /*Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
     * В результате вся информация выводится в одну строчку:
    а) используя склеивание; */
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

            //очистка консоли
            Console.Clear();
            
            Console.WriteLine(name + " " + surname + ": " + age + " лет, " + h + " см, " + w + " кг.");

            //альтернативный вариант
            /*string str = String.Concat(name, " ", surname, ": ", age, " лет, ", h, " см, ", w, " кг.");
            Console.WriteLine(str);*/
        }
    }
}
