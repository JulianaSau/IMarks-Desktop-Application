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
using System.IO;

namespace MwalimuApplication
{
    public partial class AddStudent : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        
        public AddStudent()
        {
            InitializeComponent();
            string WorkingDirectory = Application.StartupPath + "\\";
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + WorkingDirectory + "DataStudent.accdb; Persist Security Info=False";
        }
       
        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into StudentDetails ([AdmissionNumber],[StudentName],[Age],[Dorm]) values('" + materialSingleLineTextField1.Text + "','" + materialSingleLineTextField4.Text + "','" + materialSingleLineTextField3.Text + "','" + materialSingleLineTextField2.Text + "')";
                label11.Text = "Data Saved Successfully";
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

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
        
    }
}
