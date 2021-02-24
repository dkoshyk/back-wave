using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using Wave.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Wave.Api.TaskEndpoints
{
    public class Get : BaseAsyncEndpoint
        .WithRequest<int>
        .WithResponse<TaskResult>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public Get(
            AppDbContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        [HttpGet("/api/tasks/{id}")]
        [SwaggerOperation(
            Summary = "Get Task",
            Description = "Get Task",
            OperationId = "Task.Get",
            Tags = new[] { "TaskEndpoint" })
        ]
        public override async Task<ActionResult<TaskResult>> HandleAsync(
            int id,
            CancellationToken cancellationToken = default)
        {
            var task = await _dbContext.Tasks.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            var result = _mapper.Map<TaskResult>(task);

            return Ok(result);
        }
    }
}