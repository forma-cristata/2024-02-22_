using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Class : IDepartment
    {
        public String ClassName { get; init; }
        public Department Department { get; set; }
        private String CourseCode { get; init; }
        public List<Student> Students { get; init; } = [];
        public Teacher? Teacher { get; set; }

        public Class(String className, Department department, String courseCode)
        {
            ClassName = className;
            Department = department;
            CourseCode = courseCode;
        }

        public override String ToString()
        {
            String teacher = Teacher == null ? "No Teacher" : $"{Teacher.FirstName} {Teacher.LastName}";
            return $"{ClassName} ({CourseCode}) taught by {teacher} in {Department} has {Students.Count} students";
        }
    }
}