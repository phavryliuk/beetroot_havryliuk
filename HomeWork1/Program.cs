using System;

// 1
Console.WriteLine("Введи число Х: ");

var x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ти ввiв число " + x);
Console.WriteLine("Розв'язок виразу -6*x^3+5*x^2-10*x+15");

double y = -1 * 6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;

Console.WriteLine("Результат : ");
Console.WriteLine(y);
Console.WriteLine("Натисни будь-яку кнопку для обчислення наступного виразу!");

Console.ReadKey();

// 2

Console.WriteLine("Розв'язок виразу abs(x)*sin(x)");

double z = Math.Abs(x) * Math.Sin(x);

Console.WriteLine("Результат : ");
Console.WriteLine(z);
Console.WriteLine("Натисни будь-яку кнопку для обчислення наступного виразу!");

Console.ReadKey();

// 3

Console.WriteLine("Розв'язок виразу 2*pi*x");

double h = 2 * Math.PI * x;

Console.WriteLine("Результат : ");
Console.WriteLine(h);


// 4

Console.WriteLine("А зараз порiвняємо наше перше число з якимось iншим!");
Console.WriteLine("Введи будь-яке число!");

double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ти ввiв число " + a);

if (a > x)
    Console.WriteLine("Введене число " + a + " бiльше за початкове " + x);
else
    Console.WriteLine("Введене число " + a + " менше за початкове " + x);

Console.WriteLine("Дякую!!!");
Console.ReadKey();