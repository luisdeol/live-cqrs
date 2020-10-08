using MediatR;
using System;

namespace AwesomeGymLive.Application.Commands.AddStudent
{
    public class AddStudentCommand : IRequest<Unit>
    {
        public AddStudentCommand(string fullName, DateTime birthDate, int idUit)
        {
            FullName = fullName;
            BirthDate = birthDate;
            IdUit = idUit;
        }

        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public int IdUit { get; set; }
    }
}
