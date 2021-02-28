using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Wave.Api.ApplicationCore;
using Wave.Api.Infrastructure.Data;
using Wave.Api.TaskEndpoints;

namespace Wave.Api.UserEndpoints
{
    public class List : BaseAsyncEndpoint
        .WithRequest<UserListRequest>
        .WithResponse<IList<UserListResult>>
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

        [Authorize]
        [HttpGet("/api/users")]
        [SwaggerOperation(
            Summary = "List all Users",
            Description = "List all Users",
            OperationId = "User.List",
            Tags = new[] { "UserEndpoint" })
        ]
        public override async Task<ActionResult<IList<UserListResult>>> HandleAsync(
            [FromQuery] UserListRequest request,
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

            IQueryable<User> query = _dbContext.Users;

            var result = (await query
                .Skip(request.PerPage * (request.Page - 1))
                .Take(request.PerPage)
                .ToListAsync(cancellationToken))
                .Select(i => _mapper.Map<UserListResult>(i));

            return Ok(result);
        }
    }
}
