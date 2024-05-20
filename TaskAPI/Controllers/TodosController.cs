﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    //Attributes
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        
        private TodoService _todoService;
        public TodosController()
        {
            _todoService = new TodoService();
        }
        
        [HttpGet("{id?}")] //when we use ? after the id it tells,that's the optional parameter(means can tell null values)
        public IActionResult GetTodos(int? id)//from here also you have to put that mark
        {
            var myTodos = _todoService.AllTodos();

            if(id is null) return Ok(myTodos);

            myTodos =myTodos.Where(t => t.Id == id).ToList();

            return Ok(myTodos);
        }

        
    }
}
