using System;

namespace LINQ
{
    public abstract class Person
    {
        public String FirstName { get; init; }
        public String LastName { get; init; }
        public int Age { get; init; }

        public Person(String firstName, String lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override String ToString() => $"{FirstName} {LastName} is {Age} years old";
    }
}
