using System;

namespace AwesomeGymLive.Domain.Entities
{
    public class Student
    {
        public Student(string fullName, DateTime birthDate)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Active = true;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; private set; }
    }
}
