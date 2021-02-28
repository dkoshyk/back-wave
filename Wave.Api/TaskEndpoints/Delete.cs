using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using Wave.Api.Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;

namespace Wave.Api.TaskEndpoints
{
    public class Delete : BaseAsyncEndpoint
        .WithRequest<DeleteTaskRequest>
        .WithoutResponse
    {
        private readonly AppDbContext _dbContext;

        public Delete(
            AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Authorize]
        [HttpDelete("/api/tasks/{id}")]
        [SwaggerOperation(
            Summary = "Deletes a Task",
            Description = "Deletes a Task",
            OperationId = "Task.Delete",
            Tags = new[] { "TaskEndpoint" })
        ]
        public override async Task<ActionResult> HandleAsync(
            DeleteTaskRequest request,
            CancellationToken cancellationToken = default)
        {
            var task = await _dbContext.Tasks.FindAsync(request.Id);

            if (task is null)
            {
                return NotFound(request.Id);
            }

            _dbContext.Tasks.Remove(task);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return NoContent();
        }
    }
}