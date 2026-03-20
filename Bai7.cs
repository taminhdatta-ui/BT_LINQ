using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//MSV: 2415053122107
//Ho va ten: Ta Minh Dat
// Lop: 225LTC#02
class Bai7
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 5, 8, 12, 3 };
        bool hasGreaterThan10 = numbers.Any(n => n > 10);
        Console.WriteLine("Co so lon hon  10 không? " + hasGreaterThan10);
    }
}