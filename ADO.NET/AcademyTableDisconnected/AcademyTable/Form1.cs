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
        static public SqlDataAdapter Adapter { get; set; }
        public DataSet Ds { get; set; }
        public SqlCommandBuilder CommandBuilder { get; set; }

        public Form1()
        {
            InitializeComponent();
            _dbConfigService = new("AcademyWayne");
            Ds = new();
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
            Ds.Clear();
            using SqlCommand command = new($"SELECT * FROM {tableComboBox.SelectedItem}");

            Adapter = new(command.CommandText, _connectionString);
            CommandBuilder = new(Adapter);

            Adapter.Fill(Ds);

            dataGridView.DataSource = Ds.Tables[0];
        }

        private void nonQueryBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new(_dbConfigService.GetConnectionString());
            conn.Open();

            SqlParameter param = new("name", queryTextBox.Text);

            using SqlCommand command = new($"insert into Test(Name) values(@name);", conn);

            command.Parameters.Add(param);

            command.ExecuteNonQuery();
        }
    }
}