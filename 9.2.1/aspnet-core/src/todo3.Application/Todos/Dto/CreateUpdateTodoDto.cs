using Abp.Application.Services.Dto;

namespace todo3.Todos.Dto
{
    public class CreateUpdateTodoDto : EntityDto<int>, IInputDto
    {
        public string Title { get; set; }
        public string Assignee { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
