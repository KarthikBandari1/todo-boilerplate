using Abp.Application.Services;
using Abp.Domain.Repositories;
using todo3.Todos.Dto;
using todo3.Entities;
using Abp.Application.Services.Dto;

namespace todo3.Todos
{
    public class TodoAppService : AsyncCrudAppService<Todo, TodoDto, int, PagedAndSortedResultRequestDto, CreateUpdateTodoDto, CreateUpdateTodoDto>, ITodoAppService
    {
        public TodoAppService(IRepository<Todo, int> repository) : base(repository)
        {
        }
    }
}

