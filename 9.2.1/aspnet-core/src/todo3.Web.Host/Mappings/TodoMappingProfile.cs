using AutoMapper;
using todo3.Entities;
using todo3.Todos.Dto;

namespace todo3.Web.Host.Mappings
{
    public class TodoMappingProfile : Profile
    {
        public TodoMappingProfile()
        {
            CreateMap<Todo, TodoDto>();
            CreateMap<TodoDto, Todo>();
            CreateMap<CreateUpdateTodoDto, Todo>();
            CreateMap<Todo, CreateUpdateTodoDto>();
        }
    }
}
