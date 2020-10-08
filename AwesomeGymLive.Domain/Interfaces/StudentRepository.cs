using AwesomeGymLive.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AwesomeGymLive.Domain.Interfaces
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Student student)
        {
            
        }

        public List<Student> GetAll()
        {
            return new List<Student>
            {
                new Student("luis", DateTime.Now)
            };
        }
    }
}
