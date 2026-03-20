using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//MSV: 2415053122107
//Ho va ten: Ta Minh Dat
// Lop: 225LTC#02
class Bai19

{
    static void Main()
    {
        List<int> nums = new List<int> { 1, 3, 2, 3, 4, 3, 2, 1, 3 };
        int mostFrequent = nums
            .GroupBy(n => n)                          
            .OrderByDescending(g => g.Count())        
            .First()                                 
            .Key;                                     
        Console.WriteLine("So xuat hien nhieu nhat: " + mostFrequent);
    }
}