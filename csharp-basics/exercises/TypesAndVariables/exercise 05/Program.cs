using System;

namespace exercise_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string course1 = "course1";
            string course2 = "course2";
            string course3 = "course3";

            string teacher1 = "Ms. Lapan";
            string teacher2 = "Mrs. Gideon";
            string teacher3 = "Mr. Davis";

            int classLength1 = course1.Length;
            int classLength2 = course2.Length;
            int classLength3 = course3.Length;

            int teacherLength1 = teacher1.Length;
            int teacherLength2 = teacher2.Length;
            int teacherLength3 = teacher3.Length;

            int widthCourse = 37;
            int widthTeacher = 16;

            string borderLine = new string('-', 60);
            string rowClasses1 = new string(' ', widthCourse - classLength1);
            string rowClasses2 = new string(' ', widthCourse - classLength2);
            string rowClasses3 = new string(' ', widthCourse - classLength3);

            string rowTeachers1 = new string(' ', widthTeacher - teacherLength1);
            string rowTeachers2 = new string(' ', widthTeacher - teacherLength2);
            string rowTeachers3 = new string(' ', widthTeacher - teacherLength3);

            Console.WriteLine($"+{borderLine}+");
            Console.WriteLine($"| 1 |{rowClasses1}{course1} |{rowTeachers1}{teacher1} |");
            Console.WriteLine($"| 2 |{rowClasses2}{course2} |{rowTeachers2}{teacher2} |");
            Console.WriteLine($"| 3 |{rowClasses3}{course3} |{rowTeachers3}{teacher3} |");
            Console.WriteLine($"+{borderLine}+");
        }
    }
}
