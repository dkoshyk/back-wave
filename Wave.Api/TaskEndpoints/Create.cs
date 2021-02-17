using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using Wave.Api.Infrastructure.Data;
using Wave.Api.ApplicationCore;

namespace Wave.Api.TaskEndpoints
{
    public class Create : BaseAsyncEndpoint
        .WithRequest<int>
        .WithResponse<TaskResult>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public Create(
            AppDbContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        [HttpPost("/tasks")]
        [SwaggerOperation(
            Summary = "Creates a new Task",
            Description = "Creates a new Task",
            OperationId = "Task.Create",
            Tags = new[] { "TaskEndpoint" })
        ]
        public override async Task<ActionResult<TaskResult>> HandleAsync(
            int request,
            CancellationToken cancellationToken = default)
        {
            var task = new TaskItem();
            _mapper.Map(request, task);

            await _dbContext.Tasks.AddAsync(task, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            var result = _mapper.Map<CreateTaskResult>(task);

            return Ok(result);
        }
    }
}