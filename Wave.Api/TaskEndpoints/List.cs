using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using Wave.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Wave.Api.TaskEndpoints
{
    public class List : BaseAsyncEndpoint
        .WithRequest<TaskListRequest>
        .WithResponse<IList<TaskListResult>>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public List(
            AppDbContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        [HttpGet("/tasks")]
        [SwaggerOperation(
            Summary = "List all Tasks",
            Description = "List all Tasks",
            OperationId = "Task.List",
            Tags = new[] { "TaskEndpoint" })
        ]
        public override async Task<ActionResult<IList<TaskListResult>>> HandleAsync(

            [FromQuery] TaskListRequest request,
            CancellationToken cancellationToken = default)
        {
            if (request.PerPage == 0)
            {
                request.PerPage = 10;
            }
            if (request.Page == 0)
            {
                request.Page = 1;
            }
            var result = (await _dbContext.Tasks.Skip(request.PerPage * (request.Page - 1)).Take(request.PerPage)
                .ToListAsync(cancellationToken))
                .Select(i => _mapper.Map<TaskListResult>(i));

            return Ok(result);
        }
    }
}
