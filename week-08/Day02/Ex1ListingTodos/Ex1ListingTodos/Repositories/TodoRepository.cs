﻿using Ex1ListingTodos.Entities;
using Ex1ListingTodos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1ListingTodos.Repositories
{
    public class TodoRepository
    {
        TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public void Add()
        {
            todoContext.Todos.Add(new Todo()
            {
                Id = 1,
                Title = "Say hello",
                IsUrgent = false,
                IsDone = false
            });
            todoContext.SaveChanges();
        }
    }
}
