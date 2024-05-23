using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using todo3.Todos.Dto;
using Abp.Application.Services.Dto;


namespace todo3.Todos
{
    public interface ITodoAppService : IAsyncCrudAppService<TodoDto, int, PagedAndSortedResultRequestDto, CreateUpdateTodoDto, CreateUpdateTodoDto>
    {
    }
}
