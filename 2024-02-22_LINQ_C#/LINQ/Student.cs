using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Student : Person
    {
        public const float HONOR_GPA = 3.5f;

        private float _gpa;
        public float GPA { get => _gpa; 
            set
            {
                if (value < 0 || value > 4)
                {
                    throw new ArgumentOutOfRangeException("GPA must be between 0 and 4");
                }
                _gpa = value;
            } 
        }

        public Student(String firstName, String lastName, int age, float GPA)
            : base(firstName, lastName, age) => this.GPA = GPA;

        public bool IsHonorStudent() => GPA >= HONOR_GPA;

        public override String ToString() => base.ToString() + $" and has a GPA of {GPA:F2}";
    }
}
