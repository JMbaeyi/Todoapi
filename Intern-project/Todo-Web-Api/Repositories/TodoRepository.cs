using System;
using Todo_Web_Api.DTOs;
using Todo_Web_Api.Interfaces;
using Todo_Web_Api.Models;

namespace Todo_Web_Api.Repositories;

public class TodoRepository : ITodoRepository
{
    private static List<Todo> todos = new List<Todo>();
    public int Create(TodoRequest request)
    {
        var todo = new Todo
        {
            Id = todos.Count + 1,
            Name = request.Name,
            DateToBeCompleted = request.DateToBeCompleted,
            IsCompleted = false
        };

        todos.Add(todo);
        
        return todo.Id;
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<TodoResponse> GetCompletedTodos()
    {
        var myTodos = todos.Select(todo => new TodoResponse
        {
            Id = todo.Id,
            Name = todo.Name,
            DateToBeCompleted = todo.DateToBeCompleted,
            IsCompleted = todo.IsCompleted
        }).Where(todo => todo.IsCompleted).ToList();

        return myTodos;
    }

    public TodoResponse GetTodoById(int id)
    {
        var todo = todos.Select(todo => new TodoResponse
        {
            Id = todo.Id,
            Name = todo.Name,
            DateToBeCompleted = todo.DateToBeCompleted,
            IsCompleted = todo.IsCompleted
        }).FirstOrDefault(todo => todo.Id == id);

        return todo;
    }

    public List<TodoResponse> GetTodos()
    {
        var myTodos = todos.Select(todo => new TodoResponse
        {
            Id = todo.Id,
            Name = todo.Name,
            DateToBeCompleted = todo.DateToBeCompleted,
            IsCompleted = todo.IsCompleted
        }).ToList();

        return myTodos;
    }

    public List<TodoResponse> GetUncompletedTodos()
    {
        throw new NotImplementedException();
    }

    public void SetTodoAsCompleted(int id)
    {
        var todo = todos.FirstOrDefault(todo => todo.Id == id);

        if(todo != null)
        {
            todo.IsCompleted = true;
        }
    }
}
