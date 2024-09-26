using System;

namespace Todo_Web_Api.DTOs;

public class TodoResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateToBeCompleted { get; set; }
    public bool IsCompleted { get; set; }
}
