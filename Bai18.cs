using System;
using System.Collections.Generic;
using System.Linq;
// MSV: 2415053122107
// Ho va ten: Ta Minh Dat
// Lop: 225LTC#02
namespace Bai18
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
    class Bai18
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
            var grouped = students
                .GroupBy(s => {
                    if (s.Score >= 8) return "Gioi";
                    else if (s.Score >= 6) return "Kha";
                    else return "Trung binh";
                });

            foreach (var group in grouped)
            {
                Console.WriteLine($"\n--- {group.Key} ---");
                foreach (var s in group)
                    Console.WriteLine($"  {s.Name}: {s.Score}");
            }
        }
    }
}