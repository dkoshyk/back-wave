using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using Wave.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Wave.Api.TaskEndpoints;

namespace Wave.Api.UserEndpoints
{
    public class Get : BaseAsyncEndpoint
        .WithRequest<int>
        .WithResponse<UserResult>
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
        [HttpGet("/api/users/{id}")]
        [SwaggerOperation(
            Summary = "Get User",
            Description = "Get User",
            OperationId = "User.Get",
            Tags = new[] { "UserEndpoint" })
        ]
        public override async Task<ActionResult<UserResult>> HandleAsync(
            int id,
            CancellationToken cancellationToken = default)
        {
            var task = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            var result = _mapper.Map<UserResult>(task);

            return Ok(result);
        }
    }
}