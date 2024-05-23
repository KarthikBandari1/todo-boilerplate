using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using todo3.Entities; // Assuming Todo entity is defined in todo3.Entities namespace

namespace todo3.Todos.Dto
{
    [AutoMapFrom(typeof(Todo))] // Assuming Todo entity is mapped from the TodoDto
    public class TodoDto : EntityDto<int>
    {
        public string Title { get; set; }
        public string Assignee { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
