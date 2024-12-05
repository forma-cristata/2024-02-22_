using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class DummyData
    {
        private const int SEED = 18961218;
        private static readonly Random random = new Random(SEED);

        public static List<Student> GenerateStudents()
        {
            return new List<Student>
            {
                new Student("John", "Smith", 18, 3.5f),
                new Student("Jane", "Doe", 19, 3.21f),
                new Student("Bob", "Smith", 20, 2.55f),
                new Student("Sally", "Doe", 21, 2.03f),
                new Student("Joe", "Johnson", 22, 1.95f),
                new Student("Mary", "Johnson", 23, 1.60f),
                new Student("Bill", "Williams", 24, 1.5f),
                new Student("Sue", "Williams", 25, 3.1f),
                new Student("Fred", "Jones", 26, 3.3f),
                new Student("Barbara", "Jones", 27, 3.4f),
                new Student("George", "Brown", 28, 3.5f),
                new Student("Alice", "Brown", 59, 2.6f),
                new Student("Sam", "Davis", 30, 2.7f),
                new Student("Jill", "Davis", 31, 2.8f),
                new Student("Jack", "Miller", 42, 2.9f),
                new Student("Peggy", "Miller", 33, 3.0f),
                new Student("Harry", "Wilson", 34, 3.1f),
                new Student("Janet", "Wilson", 35, 3.2f),
                new Student("Ron", "Moore", 36, 3.3f),
                new Student("Carol", "Moore", 17, 3.4f),
                new Student("Greg", "Taylor", 38, 3.5f),
                new Student("Laura", "Taylor", 39, 3.6f),
                new Student("Chris", "Anderson", 40, 3.7f),
                new Student("Linda", "Anderson", 41, 3.8f),
                new Student("Paul", "Thomas", 42, 3.9f),
                new Student("Karen", "Thomas", 43, 4.0f),
                new Student("Tim", "Jackson", 44, 0.5f),
                new Student("Donna", "Jackson", 45, 0.6f),
                new Student("Phil", "Smith", 18, 0.7f),
                new Student("Sandra", "Doe", 19, 0.8f),
                new Student("Robert", "Smith", 20, 0.9f),
                new Student("Sarah", "Doe", 21, 1.0f),
                new Student("Joseph", "Johnson", 22, 1.1f),
                new Student("Maria", "Johnson", 23, 1.2f),
            };
        }

        public static List<Teacher> GenerateTeachers()
        {
            return new List<Teacher>()
            {
                new Teacher("John", "Smith", 30, 50000, Department.English),
                new Teacher("Jane", "Doe", 35, 60000, Department.Math),
                new Teacher("Bob", "Smith", 40, 70000, Department.Science),
                new Teacher("Sally", "Doe", 45, 85000, Department.History),
                new Teacher("Joe", "Johnson", 50, 92000, Department.Art),
                new Teacher("Mary", "Johnson", 55, 100000, Department.Music),
                new Teacher("Bill", "Williams", 60, 100000, Department.HealthAndPhysEd),
                new Teacher("Sue", "Williams", 65, 110000, Department.ComputerScience),
                new Teacher("Fred", "Jones", 69, 39000, Department.Business),
                new Teacher("Barbara", "Jones", 75, 47000, Department.English),
                new Teacher("George", "Brown", 42, 150000, Department.Math),
                new Teacher("Alice", "Brown", 55, 67000, Department.Science),
                new Teacher("Sam", "Davis", 80, 61000, Department.History),
                new Teacher("Jill", "Davis", 65, 87000, Department.Art),
                new Teacher("Nicholas", "Page", 26, 100000, Department.ComputerScience),//Nice salary, bud
                new Teacher("Jack", "Miller", 61, 190000, Department.Music),
                new Teacher("Peggy", "Miller", 45, 59400, Department.HealthAndPhysEd),
                new Teacher("Harry", "Wilson", 50, 81000, Department.ComputerScience),
                new Teacher("Janet", "Wilson", 55, 54000, Department.Business),
                new Teacher("Ron", "Moore", 52, 99000, Department.English),
                new Teacher("Carol", "Moore", 42, 99900, Department.Math),
                new Teacher("Greg", "Taylor", 49, 79000, Department.Science),
                new Teacher("Laura", "Taylor", 68, 60000, Department.History),
                new Teacher("Chris", "Anderson", 61, 61000, Department.Art),
                new Teacher("Linda", "Anderson", 62, 75120, Department.Music),
                new Teacher("Paul", "Thomas", 35, 90000, Department.HealthAndPhysEd),
                new Teacher("Karen", "Thomas", 55, 94000, Department.ComputerScience),
                new Teacher("Tim", "Jackson", 60, 71000, Department.Business),
                new Teacher("Donna", "Jackson", 65, 72000, Department.English)
            };
        }

        public static List<Class> GenerateClasses(List<Teacher> teachers, List<Student> students)
        {
            return new List<Class>
            {
                new Class("English 1", Department.English, "ENGL101")
                {
                    Students = GetRandomDistinct(students, 6),
                    Teacher = teachers.Where(x => x.Department == Department.English).ToArray()[0]
                },
                new Class("English 2", Department.English, "ENGLE102")
                {
                    Students = GetRandomDistinct(students, 6),
                    Teacher = teachers.Where(x => x.Department == Department.English).ToArray()[1]
                },
                new Class("Calculus 1", Department.Math, "MATH240")
                {
                    Students = GetRandomDistinct(students, 11),
                    Teacher = teachers.Where(x => x.Department == Department.Math).ToArray()[0]
                },
                new Class("Calculus 2", Department.Math, "MATH241")
                {
                    Students = GetRandomDistinct(students, 7),
                    Teacher = teachers.Where(x => x.Department == Department.Math).ToArray()[1]
                },
                new Class("Differential Equations", Department.Math, "MATH301")
                {
                    Students = GetRandomDistinct(students, 4),
                    Teacher = teachers.Where(x => x.Department == Department.Math).ToArray()[2]
                },
                new Class("Elements of Linear Algebra ", Department.Math, "MATH311")
                {
                    Students = GetRandomDistinct(students, 4),
                    Teacher = teachers.Where(x => x.Department == Department.Math).ToArray()[2]
                },
                new Class("Organic Chemistry", Department.Science, "CHEM160")
                {
                    Students = GetRandomDistinct(students, 6),
                    Teacher = teachers.Where(x => x.Department == Department.Science).ToArray()[0]
                },
                new Class("Physics 1", Department.Science, "PHYS140")
                {
                    Students = GetRandomDistinct(students, 6),
                    Teacher = teachers.Where(x => x.Department == Department.Science).ToArray()[1]
                },
                new Class("How Stuff Works", Department.Science, "PHYS130")
                {
                    Students = GetRandomDistinct(students, 9),
                    Teacher = teachers.Where(x => x.Department == Department.Science).ToArray()[2]
                },
                new Class("The Cultural Impact of Colonization", Department.History, "HIST114")
                {
                    Students = GetRandomDistinct(students, 3),
                    Teacher = teachers.Where(x => x.Department == Department.History).ToArray()[0]
                },
                new Class("Historical, Behavioral, and Social Science Inquiry", Department.History, "HIST211")
                {
                    Students = GetRandomDistinct(students, 3),
                    Teacher = teachers.Where(x => x.Department == Department.History).ToArray()[1]
                },
                new Class("U.S. History I", Department.History, "HIST201")
                {
                    Students = GetRandomDistinct(students, 5),
                    Teacher = teachers.Where(x => x.Department == Department.History).ToArray()[2]
                },
                new Class("Introduction to 3D Design", Department.Art, "ART105")
                {
                    Students = GetRandomDistinct(students, 7),
                    Teacher = teachers.Where(x => x.Department == Department.Art).ToArray()[0]
                },
                new Class("Color and 2-Dimensional Design", Department.Art, "ART110")
                {
                    Students = GetRandomDistinct(students, 7),
                    Teacher = teachers.Where(x => x.Department == Department.Art).ToArray()[1]
                },
                new Class("Digital Art", Department.Art, "ART217")
                {
                    Students = GetRandomDistinct(students, 7),
                    Teacher = teachers.Where(x => x.Department == Department.Art).ToArray()[2]
                },
                new Class("World Music", Department.Music, "MUSI100")
                {
                    Students = GetRandomDistinct(students, 7),
                    Teacher = teachers.Where(x => x.Department == Department.Music).ToArray()[0]
                },
                new Class("Introduction to Music", Department.Music, "MUSI101")
                {
                    Students = GetRandomDistinct(students, 7),
                    Teacher = teachers.Where(x => x.Department == Department.Music).ToArray()[1]
                },
                new Class("Symphonic Music", Department.Music, "MUSI319")
                {
                    Students = GetRandomDistinct(students, 6),
                    Teacher = teachers.Where(x => x.Department == Department.Music).ToArray()[2]
                },
                new Class("Teaching Invasion Sports 1", Department.HealthAndPhysEd, "HPED115")
                {
                    Students = GetRandomDistinct(students, 10),
                    Teacher = teachers.Where(x => x.Department == Department.HealthAndPhysEd).ToArray()[0]
                },
                new Class("Swimming/Emergency Water Safety", Department.HealthAndPhysEd, "HPED134")
                {
                    Students = GetRandomDistinct(students, 11),
                    Teacher = teachers.Where(x => x.Department == Department.HealthAndPhysEd).ToArray()[1]
                },
                new Class("Wellness for Life", Department.HealthAndPhysEd, "HPED140")
                {
                    Students = GetRandomDistinct(students, 12),
                    Teacher = teachers.Where(x => x.Department == Department.HealthAndPhysEd).ToArray()[2]
                },
                new Class("Principles of Coaching", Department.HealthAndPhysEd, "HPED162")
                {
                    Students = GetRandomDistinct(students, 8),
                    Teacher = teachers.Where(x => x.Department == Department.HealthAndPhysEd).ToArray()[2]
                },
                new Class("Teaching Fitness in K-12 Schools", Department.HealthAndPhysEd, "HPED255")
                {
                    Students = GetRandomDistinct(students, 7),
                    Teacher = teachers.Where(x => x.Department == Department.HealthAndPhysEd).ToArray()[0]
                },
                new Class("Intro to Comp & Prob Solving", Department.ComputerScience, "COMP119")
                {
                    Students = GetRandomDistinct(students, 12),
                    Teacher = teachers.Where(x => x.Department == Department.ComputerScience).ToArray()[0]
                },
                new Class("Introduction to Computers", Department.ComputerScience, "COMP150")
                {
                    Students = GetRandomDistinct(students, 12),
                    Teacher = teachers.Where(x => x.Department == Department.ComputerScience).ToArray()[1]
                },
                new Class("Programming I", Department.ComputerScience, "COMP160")
                {
                    Students = GetRandomDistinct(students, 11),
                    Teacher = teachers.Where(x => x.Department == Department.ComputerScience).ToArray()[2]
                },
                new Class("Fundamentals of Networking", Department.ComputerScience, "COMP200")
                {
                    Students = GetRandomDistinct(students, 11),
                    Teacher = teachers.Where(x => x.Department == Department.ComputerScience).ToArray()[3]
                },
                new Class("Operating System Concepts and System Administration", Department.ComputerScience, "COMP202")
                {
                    Students = GetRandomDistinct(students, 11),
                    Teacher = teachers.Where(x => x.Department == Department.ComputerScience).ToArray()[2]
                },
                new Class("Contemporary Issues in Computing", Department.ComputerScience, "COMP220")
                {
                    Students = GetRandomDistinct(students, 10),
                    Teacher = teachers.Where(x => x.Department == Department.ComputerScience).ToArray()[2]
                },
                new Class("Discrete Structures & Formal Languages", Department.ComputerScience, "COMP230")
                {
                    Students = GetRandomDistinct(students, 10),
                    Teacher = teachers.Where(x => x.Department == Department.ComputerScience).ToArray()[1]
                },
                new Class("Computer Graphics", Department.ComputerScience, "COMP430")
                {
                    Students = GetRandomDistinct(students, 8),
                    Teacher = teachers.Where(x => x.Department == Department.ComputerScience).ToArray()[1]
                },
                new Class("Introduction to Business", Department.Business, "MANG105")
                {
                    Students = GetRandomDistinct(students, 11),
                    Teacher = teachers.Where(x => x.Department == Department.Business).ToArray()[0]
                },
                new Class("Financial Accounting", Department.Business, "ACCT110")
                {
                    Students = GetRandomDistinct(students, 8),
                    Teacher = teachers.Where(x => x.Department == Department.Business).ToArray()[1]
                }
            };
        }
        
        private static List<T> GetRandomDistinct<T>(List<T> list, short count = 1)
        {
            List<T> result = [];

            while(count-- > 0)
            {
                result.Add(list[random.Next(list.Count)]);
            }

            return result.Distinct().ToList();
        }
    }
}
