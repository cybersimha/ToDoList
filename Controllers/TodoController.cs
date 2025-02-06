using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodoList.Models; // Make sure this namespace matches your project

namespace TodoList.Controllers
{
    public class TodoController : Controller
    {
        private static List<TodoItem> todoItems = new List<TodoItem>(); // In-memory storage
        private static int nextId = 1; // To generate unique IDs

        public IActionResult Index()
        {
            return View(todoItems);
        }

        [HttpPost]
        public IActionResult Add(string title, DateTime dueDate, string priority, TodoStatus status, string comments)
        {
            if (!string.IsNullOrEmpty(title))
                {
                    todoItems.Add(new TodoItem { Id = nextId++, Title = title, IsCompleted = false, DueDate = dueDate, Priority = priority, Status= status, Comments = comments });
                }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var itemToRemove = todoItems.Find(item => item.Id == id);
            if (itemToRemove != null)
            {
                todoItems.Remove(itemToRemove);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}