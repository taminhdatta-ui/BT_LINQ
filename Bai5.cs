using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//MSV: 2415053122107
//Ho va ten: Ta Minh Dat
// Lop: 225LTC#02
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        var squares = numbers.Select(n => n * n).ToList();
        Console.WriteLine("Bình phương: " + string.Join(", ", squares));
    }
}