using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            while (true)
            {
                Console.WriteLine("1. Найти максимальное из четырех чисел. Массивы не использовать.");
                Console.WriteLine("2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах.");
                Console.WriteLine("3. Ввести возраст человека (от 1 до 150 лет) и вывести его вместе с последующим словом «год», «года» или «лет».");
                Console.WriteLine("4. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее арифметическое всех положительных четных чисел, оканчивающихся на 8.");
                Console.WriteLine("0. Выход");
                Console.Write("Ввод: ");

                line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        firstSolution();
                        break;
                    case "2":
                        secondSolution();
                        break;
                    case "3":
                        thirdSolution();
                        break;
                    case "4":
                        fourSolution();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Не корректный ввод");
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void fourSolution()
        {
            Console.WriteLine("fourSolution input");
        }

        private static void thirdSolution()
        {
            Console.WriteLine("thirdSolution input");
        }

        private static void secondSolution()
        {
            Console.WriteLine("secondSolution input");
        }

        private static void firstSolution()
        {
            Console.WriteLine("firstSolution input");
        }
    }
}
