using TaskMVP.Model;
using TaskMVP.Presenter;
using TaskMVP.View;

namespace TaskMVP
{
    public partial class TodoView : Form
    {
        public TodoPresenter Presenter { get; set; }

        public TodoView()
        {
            Presenter = new(this);
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            var res = Presenter.AddTask(
                name_textBox.Text,
                desc_textBox.Text,
                isImportant_checkBox.Checked,
                dateTimePicker1.Value
            );

            task_listBox.Items.Add(res);
        }

        private void task_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            var selected = task_listBox.SelectedItems;

            for (int i = 0; i < selected.Count; i++)
            {
                task_listBox.Items.Remove(selected[i] as Todo);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            var editWindow = new EditView(task_listBox.SelectedItem as Todo);

            editWindow.Show();
            
            // editWindow.ShowDialog();
            // this.WindowState = FormWindowState.Minimized;
        }
    }
}