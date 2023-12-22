
using System;
using System.Collections.Generic; // использовать List<T>
class work_1_4
{
    static void Main()
    {
        Console.Write("Введите начало диапазона: "); // вывод инфы
        int x = Convert.ToInt32(Console.ReadLine()); // начало диапазона
        Console.Write("Введите конец диапазона: "); // вывод инфы
        int y = Convert.ToInt32(Console.ReadLine()); // конец диапазона
        
        int[] array = new int[10]; // массив
        Random rand = new Random(); // объявляем генератор 
        
        Console.Write("Массив: "); // вывод инфы
        for (int i = 0; i < 10; i++)
        {
            array[i] = rand.Next(x, y); // заполняем массив
        }
        var str = string.Join(" ", array); // var - переменная без какого-либо типа данных (разделитель, значение)
        Console.WriteLine(str); // вывод str
    }
}
