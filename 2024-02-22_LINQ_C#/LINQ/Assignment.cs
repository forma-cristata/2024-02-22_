/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace LINQ
{
    public class Assignment
    {
        private static readonly List<Student> students = DummyData.GenerateStudents();
        private static readonly List<Teacher> teachers = DummyData.GenerateTeachers();
        private static readonly List<Class> classes = DummyData.GenerateClasses(teachers, students);

        public static void Run()
        {
            //(1 pt)
            Console.WriteLine($"Teacher paid the most: {GetTeacherPaidTheMost()}");
			Console.Write(Environment.NewLine);

			//(1 pt)
			Console.WriteLine($"Oldest student: {GetOldestStudent()}");
            Console.Write(Environment.NewLine);

            //(2 pts)
            const float gpaTarget = 3.4f;
            Console.WriteLine($"Students with a GPA over {gpaTarget}: \n{Program.StringifyList(GetStudentsWithGPAOver(gpaTarget))}");
			Console.Write(Environment.NewLine);

			//(2 pts)
			Class targetClass = classes.Where(x => x.Department == Department.ComputerScience).First();
			Console.WriteLine($"Highest GPA student in class {targetClass.ClassName}: {GetHighestGPAStudentInClass(targetClass)}");
			Console.Write(Environment.NewLine);


			//(3 pts)
			const Department deptTarget = Department.ComputerScience;
			const int numOfStudentsTarget = 9;
			Console.WriteLine($"Classes with over {numOfStudentsTarget} students in {deptTarget}: " +
			    $"{Program.StringifyList(GetClassesInDepartmentWithOverXStudents(deptTarget, numOfStudentsTarget))}");
			Console.Write(Environment.NewLine);


			//(3 pts)
			const Department deptTarget2 = Department.English;
			Console.WriteLine($"Highest GPA student in department {deptTarget2}: {GetHighestGPAStudentInDepartment(deptTarget2)}");
			Console.Write(Environment.NewLine);

		}
		private static Teacher GetTeacherPaidTheMost()
        {
            List<Teacher> _teachers = [.. teachers
                                          .OrderByDescending(x => x.Salary)];
            return _teachers
                   .First();
        }
        private static Student GetOldestStudent()
        {
            List<Student> _students = [.. students.OrderByDescending(x => x.Age)];
            return _students
                   .First();
        }
        private static List<Student> GetStudentsWithGPAOver(float gpa)
        {
            return [.. students
                       .Where(x => x.GPA > gpa)];
        }
        private static Student GetHighestGPAStudentInClass(Class targetClass)//TODO WTFFFFFF
        {
            return targetClass
                   .Students
                   .OrderByDescending(x => x.GPA)
                   .ToList()
                   .First();
        }
        private static List<Class> GetClassesInDepartmentWithOverXStudents(Department dept, int minNumOfStudents)
        {
			return [.. classes
                              .Where(x => x.Students.Count > minNumOfStudents)
                              .Where(x => x.Department.Equals(dept))];
        }

        private static Student GetHighestGPAStudentInDepartment(Department targetDept)
        {
            return classes.Where(x => x
                                       .Department
                                       .Equals(targetDept))
                                       .SelectMany(x => x.Students)
                                       .OrderByDescending(x => x.GPA)
                                       .First();
        }
    }
}
