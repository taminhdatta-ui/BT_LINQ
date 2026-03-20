using System;
using System.Collections.Generic;
using System.Linq;
// MSV: 2415053122107
// Ho va ten: Ta Minh Dat
// Lop: 225LTC#02
namespace Bai20
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
    class Bai20
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id=1, Name="An",   Score=8 },
                new Student { Id=2, Name="Binh", Score=6 },
                new Student { Id=3, Name="Chi",  Score=9 },
                new Student { Id=4, Name="Dung", Score=7 }
            };
            var top3 = students
                .OrderByDescending(s => s.Score)
                .Take(3)
                .ToList();

            Console.WriteLine("Top 3 sinh vien:");
            for (int i = 0; i < top3.Count; i++)
                Console.WriteLine($"  #{i + 1}: {top3[i].Name} - {top3[i].Score}");
        }
    }
}