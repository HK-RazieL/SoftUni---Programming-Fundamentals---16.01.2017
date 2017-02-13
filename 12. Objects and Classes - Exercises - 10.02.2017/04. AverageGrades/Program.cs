namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var temp = Console.ReadLine().Split().ToList();
                var grades = temp.Skip(1).Select(double.Parse).ToArray().Average();

                var student = new Student();
                student.Name = temp[0];
                student.Grades = grades;

                list.Add(student);
            }

            foreach (var item in list.OrderBy(x => x.Name).ThenByDescending(x => x.Grades))
            {
                if (item.Grades >= 5)
                {
                    Console.WriteLine($"{item.Name} -> {item.Grades:F2}");
                }
            }
        }
    }
}
