using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Service
{
    public interface ITodoRepository
    {
        public List<Todo> AllTodos();


    }
}
