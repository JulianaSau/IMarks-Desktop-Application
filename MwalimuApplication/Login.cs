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
using System.Resources;

namespace MwalimuApplication
{
    public partial class Login : Form
    {
       private OleDbConnection connection = new OleDbConnection();

        public Login()
        {
            
            InitializeComponent();
            string WorkingDirectory = Application.StartupPath + "\\";
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + WorkingDirectory + "DataStudent.accdb; Persist Security Info=False";
            Password.ForeColor= Color.WhiteSmoke;
            Username.ForeColor = Color.WhiteSmoke;

        }
        
        SIgnup signup = new SIgnup();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                signup.Show();
               
                connection.Open();
                checkConnection.Text = "Connection Secure";
                checkConnection.Visible = false;
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
            
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
           
            connection.Open();
            OleDbCommand command = new OleDbCommand("select * from Login where [UserName]='" + Username.Text + "' and [Password]='" + Password.Text + "'",connection);
            
            OleDbDataReader reader = command.ExecuteReader();
            if (Username.Text==string.Empty ||Password.Text==string.Empty)
            {
                checkConnection.Text = "Please fill all available fields";
                checkConnection.Visible = Visible;
                connection.Close();
            }
            else
            {
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;


                }
                if (count == 1)
                {
                    checkConnection.Text = "Login Successful";
                    checkConnection.Visible = Visible;
                    connection.Close();
                    connection.Dispose();
                    signup.Hide();
                    this.Hide();
                    Dashboard home = new Dashboard(Username.Text);
                    home.ShowDialog();
                }
                else if (count > 1)
                {
                    checkConnection.Text = "Please enter another username";
                    checkConnection.Visible = Visible;
                    connection.Close();
                }
                else
                {
                    checkConnection.Text = "Username or password is incorrect";
                    checkConnection.Visible = Visible;
                    connection.Close();
                }

                connection.Close();
            }

            

        }

        private void BunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            SIgnup sIgnup = new SIgnup();
            sIgnup.ShowDialog();
        }

        private void Username_Click(object sender, EventArgs e)
        {
            Username.Clear();
            pictureBox2.BackColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            Username.ForeColor = Color.FromArgb(78, 184, 206);

            
            pictureBox3.BackColor = Color.FromArgb(34, 36, 49);
            panel2.BackColor = Color.WhiteSmoke;
            Password.ForeColor = Color.WhiteSmoke;
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Clear();
            Password.PasswordChar = '*';
            pictureBox3.BackColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            Password.ForeColor = Color.FromArgb(78, 184, 206);

           
            pictureBox2.BackColor = Color.FromArgb(34,36,49);
            panel1.BackColor = Color.WhiteSmoke;
            Username.ForeColor = Color.WhiteSmoke;
        }

        private void BunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = signup.Left.ToString();
            signup.Left += 10;
            if (signup.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                signup.TopMost = true;
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = signup.Left.ToString();
            signup.Left -= 10;
            if (signup.Left <= 525)
            {
                timer2.Stop();
                this.Hide();

            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();

            SIgnup sIgnup = new SIgnup();
            sIgnup.Hide();
            this.Hide();
            forgot.ShowDialog();
        }
        
    }
}
