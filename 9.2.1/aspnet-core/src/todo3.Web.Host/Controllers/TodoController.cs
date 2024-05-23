using Abp.AspNetCore.Mvc.Controllers;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using todo3.Todos.Dto;
using todo3.Todos;

namespace todo.Web.Host.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : AbpController
    {
        private readonly ITodoAppService _todoAppService;

        public TodoController(ITodoAppService todoAppService)
        {
            _todoAppService = todoAppService;
        }

        [HttpGet]
        public async Task<ActionResult<ListResultDto<TodoDto>>> GetAll()
        {
            var todos = await _todoAppService.GetAllAsync(new PagedAndSortedResultRequestDto());
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoDto>> Get(int id)
        {
            var todo = await _todoAppService.GetAsync(new EntityDto<int>(id));
            if (todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }
        [HttpPost]
        public async Task<ActionResult<TodoDto>> Create([FromBody] CreateUpdateTodoDto input)
        {
            var todo = await _todoAppService.CreateAsync(input);
            return CreatedAtAction(nameof(Get), new { id = todo.Id }, todo);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<TodoDto>> Update(int id, [FromBody] CreateUpdateTodoDto input)
        {
            if (id != input.Id)
            {
                return BadRequest("ID in URL does not match ID in body.");
            }

            var todo = await _todoAppService.UpdateAsync(input);
            if (todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _todoAppService.DeleteAsync(new EntityDto<int>(id));
            return NoContent();
        }
    }
}