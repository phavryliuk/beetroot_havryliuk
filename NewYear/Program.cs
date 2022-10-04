using System;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime lastNY = new DateTime(2022, 1, 1);
        DateTime nextNY = new DateTime(2023, 1, 1);
        DateTime today = DateTime.Now;

        

        Console.WriteLine("Вiд попереднього Нового року минуло: " + (today - lastNY) + " днiв");
        Console.WriteLine("До наступного Нового року залишилося: " + (nextNY - today) + " днiв");
        Console.ReadKey();
    } 
}