using AwesomeGymLive.Application.Queries.GetStudents;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeGymLive.API.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var getStudentsQuery = new GetStudentsQuery();

            var result = await _mediator.Send(getStudentsQuery);

            return Ok(result);
        }
    }
}
