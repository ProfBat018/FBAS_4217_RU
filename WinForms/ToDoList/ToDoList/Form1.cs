using System.Text.RegularExpressions;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_button_MouseClick(object sender, MouseEventArgs e)
        {
            Regex re = new("[a-z,A-Z]");

            var nameLength = name_textBox.Text.Length;
            var descLength = desc_textBox.Text.Length;

            if (nameLength > 0 && descLength > 0 && re.IsMatch(name_textBox.Text))
            {
                Todo newTodo = new()
                {
                    Name = name_textBox.Text,
                    Description = desc_textBox.Text,
                    IsImportant = isImportant_checkBox.Checked,
                    Date = dateTimePicker1.Value
                };
                task_listBox.Items.Add(newTodo);
            }
            else
            {
                MessageBox.Show(
                    "Name and description length should be more than 1 symbol",
                    "Error",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
            }
            name_textBox.Text = null;
            desc_textBox.Text = null;
            isImportant_checkBox.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void task_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Todo selectedTodo = task_listBox.SelectedItem as Todo;

            MessageBox.Show(selectedTodo.ShowFull());
        }
    }
}