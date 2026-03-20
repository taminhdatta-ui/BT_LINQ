using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//MSV: 2415053122107
//Ho va ten: Ta Minh Dat
// Lop: 225LTC#02
class Bai16

{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int total = numbers.Sum();
        int sumOver3 = numbers.Where(n => n > 3).Sum();
        Console.WriteLine("Tong: " + total);           
    }
}