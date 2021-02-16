using Ardalis.ApiEndpoints;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wave.Api.ApplicationCore;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;

namespace Wave.Api.TaskEndpoints
{
    public class List : BaseAsyncEndpoint
        .WithRequest<TaskListRequest>
        .WithResponse<IList<TaskListResult>>
    {
        private readonly IAsyncRepository<TaskItem> repository;
        private readonly IMapper mapper;

        public List(
            IAsyncRepository<TaskItem> repository,
            IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
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
            var result = (await repository.ListAllAsync(request.PerPage, request.Page, cancellationToken))
                .Select(i => mapper.Map<TaskListResult>(i));

            return Ok(result);
        }
    }
}
