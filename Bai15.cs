using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//MSV: 2415053122107
//Ho va ten: Ta Minh Dat
// Lop: 225LTC#02
class Bai15

{
    static void Main()
    {
        List<int> nums = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        var distinct = nums.Distinct().ToList();
        Console.WriteLine(string.Join(", ", distinct));
    }
}