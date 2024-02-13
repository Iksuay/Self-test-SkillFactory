/*
using System;

class Exercise_1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Таблица умножения! Введите цифру с которой хотите увидеть таблицу:");
       
        int i = 0; 
        int a = Convert.ToInt32(Console.ReadLine());

        while (i <= 10)
        {
            Console.WriteLine($"{i} * {a} = {i*a}");
            i++;
        }

        
    }
}
*/

/*
using System;

class Exercise_2
{
    static void Main(string[] args)
    {

        Console.WriteLine("Введите сумму вклада: ");
        decimal sum = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите процент годовых: ");
        decimal prc = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев");
        int month = (int)Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < month; i++)
        {
            sum += sum * ((prc / 100) / 12);
        }

        Console.WriteLine(sum);
    }
}
*/

/*
using System;
class Exercise_3
{
    static void Main(string[] args)
    {
        while (true)
        {
            int a, b;

            Console.Write("Введите первое число от 0 до 10: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число от 0 до 10: ");
            b = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (a <= 0 | a < 10 | b < 0 | b <= 10)
                {
                    Console.WriteLine("Введенные числа недопустимы");
                }

                else
                {
                    a *= b;
                    Console.WriteLine("Результат умножения: " + a);
                    break;
                }
            }
        }
    }
}
*/