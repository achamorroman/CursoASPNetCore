using MiAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiAPI.Services
{
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

        public TodoList GetTodoList(int id)
        {
            throw new NotImplementedException();
        }
    }
}
