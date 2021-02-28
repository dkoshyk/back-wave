using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using Wave.Api.Infrastructure.Data;
using Wave.Api.TaskEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Wave.Api.UserEndpoints
{
    public class Delete : BaseAsyncEndpoint
        .WithRequest<DeleteUserRequest>
        .WithoutResponse
    {
        private readonly AppDbContext _dbContext;

        public Delete(
            AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Authorize]
        [HttpDelete("/api/users/{id}")]
        [SwaggerOperation(
            Summary = "Deletes a User",
            Description = "Deletes a User",
            OperationId = "USer.Delete",
            Tags = new[] { "UserEndpoint" })
        ]
        public override async Task<ActionResult> HandleAsync(
            DeleteUserRequest request,
            CancellationToken cancellationToken = default)
        {
            var user = await _dbContext.Users.FindAsync(request.Id);

            if (user is null)
            {
                return NotFound(request.Id);
            }

            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return NoContent();
        }
    }
}