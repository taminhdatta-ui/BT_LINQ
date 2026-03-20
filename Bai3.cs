using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//MSV: 2415053122107
//Ho va ten: Ta Minh Dat
// Lop: 225LTC#02
class Bai3

{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 3 };
        var sorted = numbers.OrderBy(n => n).ToList();
        Console.WriteLine("Tang dan: " + string.Join(", ", sorted));
    }
}