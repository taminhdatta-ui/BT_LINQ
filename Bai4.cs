using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//MSV: 2415053122107
//Ho va ten: Ta Minh Dat
// Lop: 225LTC#02
class Bai4

{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 2, 8, 1, 9, 3 };
        var sortedDesc = numbers.OrderByDescending(n => n).ToList();
        Console.WriteLine("Giam dan: " + string.Join(", ", sortedDesc));
    }
}