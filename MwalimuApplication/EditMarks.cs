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
    public partial class EditMarks : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        
        public EditMarks()
        {
            InitializeComponent();
            string WorkingDirectory = Application.StartupPath + "\\";
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + WorkingDirectory + "DataStudent.accdb; Persist Security Info=False";
        }

       

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Term1Marks where [AdmissionNumber]='" + comboBox1.Text + "'";
            command.CommandText = query;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               
                bunifuMaterialTextbox1.Text = reader["Mathematics"].ToString();
                bunifuMaterialTextbox2.Text = reader["English"].ToString();
                bunifuMaterialTextbox3.Text = reader["Kiswahili"].ToString();
                bunifuMaterialTextbox4.Text = reader["Science"].ToString();
                bunifuMaterialTextbox5.Text = reader["SST/RE"].ToString();
                bunifuMaterialTextbox6.Text = reader["Average"].ToString();
                bunifuMaterialTextbox7.Text = reader["Total"].ToString();
                bunifuMaterialTextbox8.Text = reader["Grade"].ToString();
                bunifuMaterialTextbox9.Text = reader["AdmissionNumber"].ToString();
               
            }
            
            connection.Close();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuThinButton23_Click(object sender, EventArgs e)
        {

           
        }

        private void Term1_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "update Term1Marks set [AdmissionNumber]='" + bunifuMaterialTextbox9.Text + "',[Mathematics]='" + bunifuMaterialTextbox1.Text + "',[English]='" + bunifuMaterialTextbox2.Text + "',[Kiswahili]='" + bunifuMaterialTextbox3.Text + "',[Science]='" + bunifuMaterialTextbox4.Text + "',[SST/RE]='" + bunifuMaterialTextbox5.Text + "',[Average]='" + bunifuMaterialTextbox7.Text + "',[Total]='" + bunifuMaterialTextbox6.Text + "',[Grade]='" + bunifuMaterialTextbox8.Text + "' where [AdmissionNumber]='" + bunifuMaterialTextbox9.Text + "'";
                label11.Text = "Data Updated Successfully";
                label11.Visible = Visible;
                command.ExecuteNonQuery();

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
                command.CommandText = "update Term2Marks set [AdmissionNumber]='" + bunifuMaterialTextbox9.Text + "',[Mathematics]='" + bunifuMaterialTextbox1.Text + "',[English]='" + bunifuMaterialTextbox2.Text + "',[Kiswahili]='" + bunifuMaterialTextbox3.Text + "',[Science]='" + bunifuMaterialTextbox4.Text + "',[SST/RE]='" + bunifuMaterialTextbox5.Text + "',[Average]='" + bunifuMaterialTextbox7.Text + "',[Total]='" + bunifuMaterialTextbox6.Text + "',[Grade]='" + bunifuMaterialTextbox8.Text + "' where [AdmissionNumber]='" + bunifuMaterialTextbox9.Text + "'";
                label11.Text = "Data Updated Successfully";
                label11.Visible = Visible;
                command.ExecuteNonQuery();

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
                command.CommandText = "update Term3Marks set [AdmissionNumber]='" + bunifuMaterialTextbox9.Text + "',[Mathematics]='" + bunifuMaterialTextbox1.Text + "',[English]='" + bunifuMaterialTextbox2.Text + "',[Kiswahili]='" + bunifuMaterialTextbox3.Text + "',[Science]='" + bunifuMaterialTextbox4.Text + "',[SST/RE]='" + bunifuMaterialTextbox5.Text + "',[Average]='" + bunifuMaterialTextbox7.Text + "',[Total]='" + bunifuMaterialTextbox6.Text + "',[Grade]='" + bunifuMaterialTextbox8.Text + "' where [AdmissionNumber]='" + bunifuMaterialTextbox9.Text + "'";
                label11.Text = "Data Updated Successfully";
                label11.Visible = Visible;
                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void Termone_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Term1Marks";
            command.CommandText = query;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["AdmissionNumber"].ToString());
            }
            label11.Text = "Data Loaded Successfully";
            label11.Visible = Visible;
            connection.Close();
        }

        private void Termtwo_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Term2Marks";
            command.CommandText = query;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["AdmissionNumber"].ToString());
            }
            label11.Text = "Data Loaded Successfully";
            label11.Visible = Visible;
            connection.Close();
        }

        private void Termthree_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Term3Marks";
            command.CommandText = query;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["AdmissionNumber"].ToString());
            }
            label11.Text = "Data Loaded Successfully";
            label11.Visible = Visible;
            connection.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "delete from Term1Marks where [AdmissionNumber]='" + comboBox1.Text + "'";
                label11.Text = "Data Deleted Successfully";
                label11.Visible = Visible;
                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void Delete1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "delete from Term2Marks where [AdmissionNumber]='" + comboBox1.Text + "'";
                label11.Text = "Data Deleted Successfully";
                label11.Visible = Visible;
                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void Delete3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "delete from Term3Marks where [AdmissionNumber]='" + comboBox1.Text + "'";
                label11.Text = "Data Deleted Successfully";
                label11.Visible = Visible;
                command.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }
    }
    
}
