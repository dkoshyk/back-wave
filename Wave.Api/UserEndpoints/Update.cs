using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using Wave.Api.Infrastructure.Data;
using Wave.Api.TaskEndpoints;

namespace Wave.Api.UserEndpoints
{
    public class Update : BaseAsyncEndpoint
        .WithRequest<UpdateUserCommand>
        .WithResponse<UpdatedUserResult>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public Update(
            AppDbContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        [HttpPut("/users")]
        [SwaggerOperation(
            Summary = "Updates an existing User",
            Description = "Updates an existing User",
            OperationId = "User.Create",
            Tags = new[] { "UserEndpoint" })
        ]
        public override async Task<ActionResult<UpdatedUserResult>> HandleAsync(
            UpdateUserCommand request,
            CancellationToken cancellationToken = default)
        {
            var user = await _dbContext.Users.FindAsync(request.Id);
            _mapper.Map(request, user);

            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync(cancellationToken);

            var result = _mapper.Map<UpdatedUserResult>(user);

            return Ok(result);
        }
    }
}