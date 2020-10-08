using AwesomeGymLive.Domain.Entities;
using System.Collections.Generic;

namespace AwesomeGymLive.Domain.Interfaces
{
    public interface IStudentRepository
    {
        void Add(Student student);
        List<Student> GetAll();
    }
}
