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
    public partial class ForgotPassword : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public ForgotPassword()
        {
            InitializeComponent();
            string WorkingDirectory = Application.StartupPath + "\\";
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + WorkingDirectory + "DataStudent.accdb; Persist Security Info=False";
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                checkConnection.Text = "Connection Secure";
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (Username.Text == string.Empty || Newpassword.Text == string.Empty || Conpassword.Text == string.Empty)
            {
                MessageBox.Show("Please fill all the available fields");
                connection.Close();
            }
            if (materialSingleLineTextField1.Text == materialSingleLineTextField2.Text)
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string query = "update Login set [Username]='" + materialSingleLineTextField3.Text + "',[Password]='" + materialSingleLineTextField1.Text + "',[Confirm Password]='" + materialSingleLineTextField2.Text + "' where [Username]='" + materialSingleLineTextField3.Text + "'";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                    MessageBox.Show(query);
                    checkConnection.Text = "Data edited successfully";
                    checkConnection.Visible = Visible;
                    connection.Close();
                    Login login = new Login();
                    this.Hide();
                    login.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connection.Close();
                }
            }
            else
            {
                checkConnection.Text = "Your passwords do not match";
                checkConnection.Visible = Visible;
                connection.Close();
            }

            
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
