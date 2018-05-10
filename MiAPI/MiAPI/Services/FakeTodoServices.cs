using MiAPI.Models;
using MiAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAPI.Services
{
    public interface ITodoService
    {
        IList<TodoList> GetTodoLists();
    }

    public class TodoService : ITodoService
    {
        private readonly ApplicationContext _context;

        public TodoService(ApplicationContext context)
        {
            _context = context;
        }

        public IList<TodoList> GetTodoLists()
        {
            return _context.TodoLists.Include(t => t.Items).ToList();
        }
    }

    public class FakeTodoService : ITodoService
    {
        public FakeTodoService() { }

        public IList<TodoList> GetTodoLists()
        {
            var list1 = new TodoList()
            {
                Id = 1,
                Name = "Lista de la compra",
                Owner = "Antonio",
                Items = new List<TodoItem>()
                {
                     new TodoItem(){ TodoListId=1, Description="Huevos" },
                     new TodoItem(){ TodoListId=1, Description="Pan" },
                     new TodoItem(){ TodoListId=1, Description="Mucha cerveza" },
                     new TodoItem(){ TodoListId=1, Description="Magdalenas" },
                }
            };

            var listCollection = new List<TodoList>
            {
                list1
            };
            return listCollection;
        }
    }
}
