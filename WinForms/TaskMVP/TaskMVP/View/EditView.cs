using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMVP.Model;

namespace TaskMVP.View
{
    public partial class EditView : Form
    {
        public Todo TaskTodo { get; set; }

        public EditView(Todo taskToDo)
        {
            TaskTodo = taskToDo;

            InitializeComponent();

            name_textBox.Text = taskToDo.Name;
            desc_textBox.Text = taskToDo.Description;
            important_checkBox.Checked = taskToDo.IsImportant;
            dateTimePicker.Value = taskToDo.Date;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
