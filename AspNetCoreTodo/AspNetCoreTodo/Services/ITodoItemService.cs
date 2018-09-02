using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemAsync();

        Task<bool> AddItemAsync(TodoItem newItem);

        Task<bool> MarkDoneAsync(Guid id);
    }
}