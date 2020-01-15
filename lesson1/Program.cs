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

        private static void firstSolution()
        {
            Console.WriteLine("Введите первое целое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе целое число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье целое число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четвертое целое число: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int max = d;
            if(a >= b && a >= c && a >= d) {
                max = a;
            } else if(b >= a && b >= c && b >= d)
            {
                max = b;
            } else if(c >= b && c >= a && c >= d)
            {
                max = c;
            }
            Console.WriteLine("Максимальное из введеных число: " + max);
        }

        private static void secondSolution()
        {
            Console.WriteLine("Введите массу тела в килограммах: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост в метрах: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Индекс массы тела: " + String.Format("{0:0.0000}", m / (h * h)));
        }

        private static void thirdSolution()
        {
            Console.WriteLine("Ввести возраст человека (от 1 до 150 лет): ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age > 150 || age < 1)
            {
                Console.WriteLine("Не корректный ввод");
            }

            if(age % 100 >= 11 && age % 100 <= 14)
            {
                Console.WriteLine(age + " лет");
            } else if (age % 10 == 1)
            {
                Console.WriteLine(age + " год");
            } else if(age % 10 >= 2 && age % 10 <= 4)
            {
                Console.WriteLine(age + " года");
            } else
            {
                Console.WriteLine(age + " лет");
            }
        }

        private static void fourSolution()
        {
            Console.WriteLine("Вводите числа, последнее число должно быть 0: ");
            int count = 0;
            double sum = 0;
            int x;
            while (true)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x > 0 && x % 10 == 8)
                {
                    sum += x;
                    count++;
                } else if(x == 0)
                {
                    if (sum == 0 || count == 0)
                    {
                        Console.WriteLine("Не было введено подходящих чисел");
                    }
                    else
                    {
                        Console.WriteLine("Cреднее арифметическое всех положительных четных чисел, оканчивающихся на 8: " + String.Format("{0:0.00}", sum / count));
                    }
                    break;
                }
            }
        }
    }
}
