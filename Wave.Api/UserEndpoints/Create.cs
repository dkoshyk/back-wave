using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using Wave.Api.Infrastructure.Data;
using Wave.Api.ApplicationCore;
using Wave.Api.TaskEndpoints;

namespace Wave.Api.UserEndpoints
{
    public class Create : BaseAsyncEndpoint
        .WithRequest<int>
        .WithResponse<UserResult>
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
        [HttpPost("/api/users")]
        [SwaggerOperation(
            Summary = "Creates a new User",
            Description = "Creates a new User",
            OperationId = "User.Create",
            Tags = new[] { "UserEndpoint" })
        ]
        public override async Task<ActionResult<UserResult>> HandleAsync(
            int request,
            CancellationToken cancellationToken = default)
        {
            var user = new User();
            _mapper.Map(request, user);

            await _dbContext.Users.AddAsync(user, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            var result = _mapper.Map<CreateUserResult>(user);

            return Ok(result);
        }
    }
}