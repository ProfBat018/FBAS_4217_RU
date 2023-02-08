using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMVP.Model;

namespace TaskMVP.Presenter
{
    public class TodoPresenter
    {
        public TodoView View { get; set; }

        public TodoPresenter(TodoView viewReference)
        {
            View = viewReference;
        }

        private static bool checkData(string name, string desc)
        {
            Regex re = new("[a-z,A-Z]");

            if (name.Length > 0 && desc.Length> 0 && re.IsMatch(name))
            {
                return true;
            }
            return false;
        }

        public Todo AddTask(string name, string desc, bool isImportant, DateTime date)
        {
            if (checkData(name, desc))
            {
                Todo newTodo = new()
                {
                    Name = name,
                    Description = desc,
                    IsImportant = isImportant,
                    Date = date
                };
                return newTodo;
            }
            throw new DataException("Incorrect data");
        }
    }
}
