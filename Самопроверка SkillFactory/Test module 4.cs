/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var myapples = 5;
        var hisapples = 6;
        var hispeares = 5;

        var result = (myapples == hispeares) & (myapples < hisapples) & (hisapples > hispeares);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var a = 5 + 6;
        var b = 7 + 8;

        var c = (b != a) & (b > a + 1);
        var d = (b != a) && (b > a + 1);

        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.ReadKey();
    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {

        var a = 5 + 6;
        var b = 7 + 8;

        var c = (b == a) & (b > a + 1);
        var d = (b == a) && (b > a + 1);

        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.ReadKey();

    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var inv = true;
        var result = !inv;

        Console.WriteLine(result);
    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {

        var a = 6;
        var b = 7;

        if (a == b)
        {
            Console.WriteLine("Условие истинно");
        }
        else
        {
            Console.WriteLine("Условие ложно");
        }

    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var a = 6;
        var b = 7;

        if (a == b && b > 1)
        {
            Console.WriteLine("Условие истинно");
        }

        else if (b > 10 || b == 7)
        {
            Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
        }
        else
        {
            Console.WriteLine("Значение b = {0}", b);
        }
    }
}
*/

/*
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        var a = 6;
        var b = 7;

        var c = a != b ? a + b : b;

        Console.WriteLine(c);
    }
}
*/
/*
Console.Write("Введите ваше имя: ");
var Name = Console.ReadLine();

foreach (var a in Name)
{
    Console.Write(a + " "); 
}

Console.WriteLine("Последняя буква ваего имени: {0}", Name[Name.Length - 1]);
*/