using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo_Web_Api.DTOs;
using Todo_Web_Api.Interfaces;
using Todo_Web_Api.Repositories;

namespace Todo_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;

        public TodoController()
        {
            _todoRepository = new TodoRepository();
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoRequest request)
        {
            var id = _todoRepository.Create(request);
            return Ok($"Todo created with id: {id}");
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var todos = _todoRepository.GetTodos();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodoById(int id)
        {
            var todo = _todoRepository.GetTodoById(id);
            return Ok(todo);
        }

        [HttpGet]
        [Route("completed-todos")]
        public IActionResult GetCompletedTodos()
        {
            var todos = _todoRepository.GetCompletedTodos();
            return Ok(todos);
        }

        [HttpGet("update-status/{id}")]
        public IActionResult SetTodoAsCompleted(int id)
        {
            _todoRepository.SetTodoAsCompleted(id);
            return Ok($"Todo with id: {id} is set as completed");
        }
    }
}
