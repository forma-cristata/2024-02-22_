using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        private static readonly String[] strNumArr = { "5", "1", "2", "3", "50" };
        private static readonly List<Student> students = DummyData.GenerateStudents();
        private static readonly List<Teacher> teachers = DummyData.GenerateTeachers();
        private static List<Person> people = null!;//Teachers and students can be in the same list because they are bothe people
        private static readonly List<Class> classes = DummyData.GenerateClasses(teachers, students);

        public static void Main()
        {

			Console.WriteLine("String array:");
            PrintList(strNumArr.ToList());

            Console.WriteLine(Environment.NewLine);

            int[] numArray = strNumArr
                .Select(x => int.Parse(x))
                .OrderByDescending(x => x)
                .ToArray();

            PrintList(numArray.ToList());

            Console.WriteLine(Environment.NewLine);

            /*String[] strArrTest = strNumArr//How to sort alphabetically
                .OrderBy(x => x)
                .ToArray();*/

            String[] strArrTest = strNumArr
                .Select(x => int.Parse(x))
                .OrderBy(x => x )
                .Select(x => x.ToString())
                .ToArray();

            PrintList(strArrTest.ToList());

            //people = new List<Person>(students.Concat(teachers));   NOOOO
			people = new List<Person>(students
                .Select(x => x as Person)
                .Concat(teachers
                .Select(x => x as Person)));

            List<Teacher> myTeachers = GetTeachersFromPeopleList();

            Console.WriteLine($"Teachers in 'person' list: {StringifyList(myTeachers)}");

            Console.WriteLine(Environment.NewLine);

            Student bestStudent = GetStudentWithHighestGPA();
            Console.WriteLine(bestStudent);

            Console.WriteLine(Environment.NewLine);
            const String name = "John";
            List<Student> johns = GetStudentsWithName(name);
            Console.WriteLine($"Students with the name {name}; {StringifyList(johns)}");

            Teacher mostClasses = GetTeacherTeachingTheMost();
            Console.WriteLine($"Teacher teaching the most classes: {mostClasses}");

            const Department deptTarget = Department.ComputerScience;
            List<Student> studentsInDept = GetStudentsTakingClassInDept( deptTarget );
            Console.WriteLine($"Students taking classes in {deptTarget}: {StringifyList(studentsInDept)}");
            Console.Clear();
			Assignment.Run();

		}

		public static void PrintList<T>(List<T> list) => list.ForEach(x => Console.WriteLine(x));
        public static String StringifyList<T>(List<T> list) => String.Join("\n", list);

        private static List<Teacher> GetTeachersFromPeopleList()
        {
            List<Person> _people = people
                .Where(x => x.GetType() == typeof(Teacher))
                .ToList();//An extension method
            return _people.Select(x => (Teacher)x).ToList();//Hard cast is not a safe cast.  x as teacher is a safe cast that returns null if x is not able to be of type teacher.
        }

        private static Student GetStudentWithHighestGPA()
        {
            List<Student> _students = [.. students.OrderBy(x => x.GPA)];
            
            return students
                .OrderByDescending(x => x.GPA)
                .First();
        }

        private static List<Student> GetStudentsWithName(String name)
        {

            List<Student> _students = students
                .Where(x => x.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase) 
                        || x.LastName.Equals(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
            return _students;
        }

        private static Teacher GetTeacherTeachingTheMost()
        {
            var grouping = classes
                .GroupBy(x => x.Teacher)//Groups by teacher, and each element of their key is their classes
                .ToList();
            var ordered = grouping
                .OrderByDescending(x => x.Count());
            return ordered
                .First()
                .Key!;
        }

        private static List<Student> GetStudentsTakingClassInDept(Department dept)
        {
            IEnumerable<Student> _studentsInDept = classes
                                                    .Where(c => c.Department == dept)
                                                    .SelectMany(x => x.Students);
            return _studentsInDept
                .Distinct()//Removes duplicates if they occur.
				.ToList();
        }
    }
}