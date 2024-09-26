using System;
using Todo_Web_Api.DTOs;

namespace Todo_Web_Api.Interfaces;

public interface ITodoRepository
{
    int Create(TodoRequest request);
    List<TodoResponse> GetTodos();
    TodoResponse GetTodoById(int id);
    void SetTodoAsCompleted(int id);
    List<TodoResponse> GetCompletedTodos();
    List<TodoResponse> GetUncompletedTodos();
    void Delete(int id);
}
