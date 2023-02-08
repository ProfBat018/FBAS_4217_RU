using AcademyTable.Services;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademyTable
{
    public partial class Form1 : Form
    {
        private readonly DbConfigService _dbConfigService;
        private string _connectionString;

        public Form1()
        {
            InitializeComponent();
            _dbConfigService = new("AcademyWayne");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _connectionString = _dbConfigService.GetConnectionString();

            if (_connectionString != null)
            {
                using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                conn.Open();

                using SqlCommand command = new("SELECT * FROM sys.tables where is_published = 1 union " +
                    "select * from sys.tables where name LIKE 'Test'", conn);

                SqlDataReader reader = command.ExecuteReader();   // ExecuteReader - считать с таблицы 
                
                while (reader.Read())   // reader.Reader is the same thing as Enumerator.Next()
                {
                    tableComboBox.Items.Add(reader[0]);
                }
                tableComboBox.SelectedItem = tableComboBox.Items[0];
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            
            using SqlConnection conn = new(_dbConfigService.GetConnectionString());
            conn.Open();

            using SqlCommand command = new($"select * from {tableComboBox.SelectedItem}", conn);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new(); // Виртуальная таблица
            DataRow dataRow; // строка для таблицы


            var cols = reader.GetColumnSchema();

            foreach (var item in cols)
            {
                dataTable.Columns.Add(item.ColumnName);
            }


            while (reader.Read()) // считывание строки из таблицы в SQL 
            {
                dataRow = dataTable.NewRow();
                for (int i = 0; i < cols.Count; i++)
                {
                    dataRow[dataTable.Columns[i].ColumnName] = reader[i]; 
                }
                dataTable.Rows.Add(dataRow);
            }

            dataGridView.DataSource = dataTable;
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var selectedItemIndex = dataGridView.SelectedRows[0].Index;

            int rowID = Convert.ToInt32(dataGridView[0, selectedItemIndex].Value);

            using SqlConnection conn = new(_dbConfigService.GetConnectionString());
            conn.Open();

            using SqlCommand command = new($"delete from {tableComboBox.SelectedItem} where Id = {rowID}", conn);

            command.ExecuteNonQuery();   // ExecuteReader - считать с таблицы 


            selectBtn_Click(sender, e);
        }

        private void nonQueryBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(_dbConfigService.GetConnectionString());
            conn.Open();

            //using SqlCommand command = new($"insert into Test(Name) values(N'{queryTextBox.Text}');", conn);

            SqlParameter param = new("name", queryTextBox.Text);

            using SqlCommand command = new($"insert into Test(Name) values(@name);", conn);

            command.Parameters.Add(param);

            command.ExecuteNonQuery();
        }
    }
}