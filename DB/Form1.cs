using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace DB
{
    public partial class Form1 : Form
    {

        string Connection = "Server=DESKTOP-ESOIDTB\\SQLEXPRESS;Integrated Security = true;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* LoadComboBox();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//Server=DESKTOP-ESOIDTB\\SQLEXPRESS;Integrated Security=true;
            DatabaseWorks database = new DatabaseWorks(Connection);
            dataGridViewStreetType.DataSource = database.ReturnTable("*", "DB2.dbo.type_street", null).Tables[0].DefaultView;
            dataGridViewAutoType.DataSource = database.ReturnTable("*", "DB2.dbo.type_auto", null).Tables[0].DefaultView;
            dataGridViewLoadStatus.DataSource = database.ReturnTable("*", "DB2.dbo.status_load", null).Tables[0].DefaultView;

            LoadComboBox();
/*            var queryListCodeRequest = "SELECT * FROM type_auto";
            loadElementToComboBox(queryListCodeRequest, "type_auto", comboBox1);*/
        }


      /*  public void loadElementToComboBox(string stringQuery, string column, ComboBox myBox)
        {
            List<string> columnValues = GetColumnValues(stringQuery, column);
            myBox.Items.AddRange(columnValues.ToArray());
        }


        public List<string> GetColumnValues(string query, string columnName)
        {
            List<string> columnValues = new List<string>();

            SqlConnection myCon = new SqlConnection(Connection);
            myCon.Open();
            using (SqlCommand command = new SqlCommand(query, myCon))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object columnValueObject = reader.GetValue(reader.GetOrdinal(columnName));
                    string columnValue = columnValueObject != DBNull.Value ? columnValueObject.ToString() : "";
                    columnValues.Add(columnValue);
                }
            }
            return columnValues;
        }*/


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            database.Addtypeauto(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            database.Addstatus_load(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            database.Addtype_street(textBox3.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LoadComboBox()
        {
            string sql = "SELECT * FROM [DB2].[dbo].[type_auto]";
            DatabaseWorks connection = new DatabaseWorks(Connection);
            using (SqlCommand cmd = new SqlCommand(sql, connection.connection))
            {
                cmd.CommandType = CommandType.Text;
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                comboBoxAutoTypeInsert.DisplayMember = "Auto";
                comboBoxAutoTypeInsert.ValueMember = "id";
                comboBoxAutoTypeInsert.DataSource = table;
            }
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            database.AddDriver(textBoxDriverName.Text, textBoxDriverSurname.Text, textBoxDriverPatron.Text);
            database.connection.Close();
        }

        private void tabControlDictionaries_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            switch (tabControlDictionaries.SelectedIndex)
            {
                case 0:
                    dataGridViewStreetType.DataSource = database.ReturnTable("*", "DB2.dbo.type_street", null).Tables[0].DefaultView;
                    break;
                case 1:
                    dataGridViewAutoType.DataSource = database.ReturnTable("*", "DB2.dbo.type_auto", null).Tables[0].DefaultView;
                    break;
                case 2:
                    dataGridViewLoadStatus.DataSource = database.ReturnTable("*", "DB2.dbo.status_load", null).Tables[0].DefaultView;
                    break;
            }
            database.connection.Close();
        }

        private void tabControlFilling_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            switch (tabControlFilling.SelectedIndex)
            {
                case 2:
                    dataGridViewBuffer.DataSource = database.ReturnTable("*", "DB2.dbo.driver", null).Tables[0].DefaultView;
                    comboBoxDriverInsert.Items.Clear();
                    for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
                    {
                        comboBoxDriverInsert.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value} {dataGridViewBuffer.Rows[i].Cells[2].Value} {dataGridViewBuffer.Rows[i].Cells[3].Value}");
                    }
                    database.connection.Close();
                    database = new DatabaseWorks(Connection);
                    dataGridViewBuffer.DataSource = database.ReturnTable("*", "DB2.dbo.type_auto", null).Tables[0].DefaultView;
                    comboBoxAutoTypeInsert.Items.Clear();
                    for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
                    {
                        comboBoxAutoTypeInsert.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
                    }
                    break;
            }
        }

        private void buttonAutoAdd_Click(object sender, EventArgs e)
        {
            DatabaseWorks database = new DatabaseWorks(Connection);
            database.AddAuto(textBoxAutoName.Text, textBoxAutoNumber.Text, comboBoxDriverInsert.Text.Split(' ')[0], comboBoxAutoTypeInsert.Text.Split(' ')[0]);
            database.connection.Close();
        }
    }
}
