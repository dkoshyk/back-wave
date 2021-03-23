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
        .WithRequest<int>
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
            int id,
            CancellationToken cancellationToken = default)
        {
            var task = await _dbContext.Tasks.FindAsync(id);

            if (task is null)
            {
                return NotFound(id);
            }

            _dbContext.Tasks.Remove(task);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return NoContent();
        }
    }
}