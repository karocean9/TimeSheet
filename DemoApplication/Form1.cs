using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoApplication
{
    public partial class Form1 : Form
    {
        List<int> clockedinIds = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            clockedinIds.Add(Convert.ToInt32(comboBox1.SelectedValue));
            SqlCommand command;
            string conString = @"Data Source=DESKTOP-SSQO2DM;Initial Catalog=TimeKeeping; User id = sa;Password=Karthik@123";
            string sql = "INSERT INTO User_Activity(Emp_id, ClockIn, ClockOut) Values(" + comboBox1.SelectedValue + " ," + "'"+ DateTime.Now.ToString()+"'" + "," + "'" +  DateTime.Now.ToString() + "'" + ")";
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            conn.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeKeepingDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.timeKeepingDataSet1.Customer);
            // TODO: This line of code loads data into the 'timeKeepingDataSet1.User_Activity' table. You can move, or remove it, as needed.
            this.user_ActivityTableAdapter.Fill(this.timeKeepingDataSet1.User_Activity);
            // TODO: This line of code loads data into the 'timeKeepingDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.timeKeepingDataSet.Customer);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(comboBox1.SelectedValue);
            if (clockedinIds.Contains(selectedId))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // remove already clockedin employee from list
            int currentEmpId = Convert.ToInt32(comboBox1.SelectedValue);
            if (clockedinIds.Contains(currentEmpId))
            {
                clockedinIds.Remove(currentEmpId);
                button1.Enabled = true;

                // disable button if it is already clocked out
                button2.Enabled = false;
            }

            button2.Text = DateTime.Now.ToString();
            SqlCommand command;
            string conString = @"Data Source=DESKTOP-SSQO2DM;Initial Catalog=TimeKeeping; User id = sa;Password=Karthik@123";


            string sql = "Select * from  User_Activity";// WHERE YEAR(" + date_created + ") = YEAR(" + date_created + " - INTERVAL 1 MONTH)" ;
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            command = new SqlCommand(sql, conn);
            //SqlDataReader dataReader = command.ExecuteReader();// multiple rows

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            DataTable result = new DataTable();
            result.Columns.Add("Emp_Id", typeof(int));
            result.Columns.Add("ClockIn", typeof(DateTime));
            result.Columns.Add("ClockOut", typeof(DateTime));
            
            foreach (DataRow row in table.Rows)
            {
                DateTime t = ((DateTime)row.ItemArray[1]);
                DateTimeSpan dateSpan = DateTimeSpan.CompareDates(t, DateTime.Now);
                if (dateSpan.Months <= 1 && dateSpan.Years == 0)
                {
                    // add this row in result
                    result.Rows.Add(new Object[] {
                        row[0],
                        row[1],
                        row[2]
                    } );
                }

            }

            dataGridView1.DataSource = result; ;
            command.Dispose();
           // dataReader.Close();
            conn.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView(object sender, DataGridViewCellEventArgs e)
        {
            // Initialize a connection string    


            // Define the database query    
            string connectionString = "Provider=SQLOLEDB;Data Source=DESKTOP-SSQO2DM; Initial Catalog=TimeKeeping;";
            string mySelectQuery = "SELECT * FROM User_Activity WHERE MONTH(DATE) = MONTH(CURRENT_TIMESTAMP) AND YEAR(DATE) = YEAR(CURRENT_TIMESTAMP)";
            var connection = new SqlConnection(connectionString);
            var adapter = new SqlDataAdapter(mySelectQuery, connection);
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dataGridView1.DataSource = table;
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    
}
