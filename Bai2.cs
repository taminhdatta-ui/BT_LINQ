using System;
using System.Collections.Generic;
using System.Linq;
//MSV: 2415053122107
//Ho va ten: Ta Minh Dat
// Lop: 225LTC#02
class Bai2
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 3, 5, 7, 9, 2, 8, 4, 6 };

        var result = numbers.Where(n => n > 5).ToList();

        Console.WriteLine("So lon hon 5: " + string.Join(", ", result));
        // Output: 7, 9, 8, 6
    }
}