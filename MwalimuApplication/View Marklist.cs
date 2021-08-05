using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MwalimuApplication
{ 
    public partial class View_Marklist : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public View_Marklist()
        {
            InitializeComponent();
            string WorkingDirectory = Application.StartupPath + "\\";
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + WorkingDirectory + "DataStudent.accdb; Persist Security Info=False";
        }

        private void View_Marklist_Load(object sender, EventArgs e)
        {
            
        }

        private void Term1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Term1Marks";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                
                da.Fill(dt);
                
                dataGridView1.DataSource = dt;
                this.dataGridView1.Sort(this.dataGridView1.Columns[6], ListSortDirection.Descending);
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void Term2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Term2Marks";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Sort(this.dataGridView1.Columns[6], ListSortDirection.Descending);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void Term3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Term3Marks";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                this.dataGridView1.Sort(this.dataGridView1.Columns[6], ListSortDirection.Descending);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
