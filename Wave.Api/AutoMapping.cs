using AutoMapper;
using Wave.Api.ApplicationCore;
using Wave.Api.TaskEndpoints;

namespace Wave.Api
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CreateTaskCommand, TaskItem>();
            CreateMap<UpdateTaskCommand, TaskItem>();

            CreateMap<TaskItem, CreateTaskResult>();
            CreateMap<TaskItem, UpdatedTaskResult>();
            CreateMap<TaskItem, TaskListResult>();
            CreateMap<TaskItem, TaskResult>();
        }
    }
}
