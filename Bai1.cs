using System;
using System.Collections.Generic;
using System.Linq;

class Bai1
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}