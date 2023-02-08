using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Todo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsImportant { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}";
        }

        public string ShowFull()
        {
            return $"Name: {Name}\n" +
                   $"Desc: {Description}\n" +
                   $"Important: {IsImportant}\n" +
                   $"Date: {Date.ToShortDateString()}\n";
        }
    }
}
