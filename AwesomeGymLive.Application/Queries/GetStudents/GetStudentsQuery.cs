using MediatR;
using System.Collections.Generic;

namespace AwesomeGymLive.Application.Queries.GetStudents
{
    public class GetStudentsQuery : IRequest<List<GetStudentsViewModel>>
    {
    }
}
