using System;

namespace Todo_Web_Api.DTOs;

public class TodoRequest
{
    public string Name { get; set; }
    public DateTime DateToBeCompleted { get; set; }
}
