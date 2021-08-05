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
    public partial class SIgnup : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public string filepath;
        public SIgnup()
        {

            InitializeComponent();

            string WorkingDirectory = Application.StartupPath + "\\";
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + WorkingDirectory + "DataStudent.accdb; Persist Security Info=False";
        }
        
        private void SIgnup_Load(object sender, EventArgs e)
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

        private void BunifuTileButton1_Click(object sender, EventArgs e)
        {
            string imageLocation;
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                    string source = dialog.FileName;
                    string dest = Application.StartupPath + "\\Images\\" + Path.GetFileName(source);
                    File.Copy(source, dest);
                    filepath = dest;
                    bunifuTileButton1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            if (fname.Text=="" || lname.Text== "" || email.Text == "" || Username.Text == "" || Password.Text == "" || Conpassword.Text == "")
            {
                MessageBox.Show("Please fill all the available fields");
                connection.Close();               
            }          
            else
            {
                if (Conpassword.Text != Password.Text)
                {
                    checkConnection.Text = "Your passwords do not match";
                    checkConnection.Visible = Visible;
                    connection.Close();
                }
                else
                {
                    try
                    {
                        connection.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = connection;
                        command.CommandText = "insert into Login ([Username],[Password],[Confirm Password],[First Name],[Last Name],[Email],[Role]) values('" + Username.Text + "','" + Password.Text + "','" + Conpassword.Text + "','" + fname.Text + "','" + lname.Text + "','" + email.Text + "',?)";

                        command.ExecuteNonQuery();
                        checkConnection.Text = "Data saved successfully";
                        connection.Close();
                        Login login = new Login();
                        login.ShowDialog();
                        this.Hide();
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                        connection.Close();
                    }
                }
                
            }

        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {
            fname.Clear();
            fpic.BackColor = Color.FromArgb(78, 184, 206);
            panelfirst.BackColor = Color.FromArgb(78, 184, 206);
            fname.ForeColor = Color.FromArgb(78, 184, 206);

            lpic.BackColor = Color.FromArgb(34, 36, 49);
            panellast.BackColor = Color.DarkSlateGray;
            lname.ForeColor = Color.DarkSlateGray;

            epic.BackColor = Color.FromArgb(34, 36, 49);
            panelemail.BackColor = Color.DarkSlateGray;
            email.ForeColor = Color.DarkSlateGray;

            Username.BackColor = Color.FromArgb(34, 36, 49);
            paneluser.BackColor = Color.DarkSlateGray;
            Username.ForeColor = Color.DarkSlateGray;

            paspic.BackColor = Color.FromArgb(34, 36, 49);
            panelpass.BackColor = Color.DarkSlateGray;
            Password.ForeColor = Color.DarkSlateGray;

            Conpassword.BackColor = Color.FromArgb(34, 36, 49);
            panelconpas.BackColor = Color.DarkSlateGray;
            Conpassword.ForeColor = Color.DarkSlateGray;
        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {
            lname.Clear();
            lpic.BackColor = Color.FromArgb(78, 184, 206);
            panellast.BackColor = Color.FromArgb(78, 184, 206);
            lname.ForeColor = Color.FromArgb(78, 184, 206);

            fpic.BackColor = Color.FromArgb(34, 36, 49);
            panelfirst.BackColor = Color.DarkSlateGray;
            fname.ForeColor = Color.DarkSlateGray;

            epic.BackColor = Color.FromArgb(34, 36, 49);
            panelemail.BackColor = Color.DarkSlateGray;
            email.ForeColor = Color.DarkSlateGray;

            Username.BackColor = Color.FromArgb(34, 36, 49);
            paneluser.BackColor = Color.DarkSlateGray;
            Username.ForeColor = Color.DarkSlateGray;

            paspic.BackColor = Color.FromArgb(34, 36, 49);
            panelpass.BackColor = Color.DarkSlateGray;
            Password.ForeColor = Color.DarkSlateGray;

            Conpassword.BackColor = Color.FromArgb(34, 36, 49);
            panelconpas.BackColor = Color.DarkSlateGray;
            Conpassword.ForeColor = Color.DarkSlateGray;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            email.Clear();
            epic.BackColor = Color.FromArgb(78, 184, 206);
            panelemail.BackColor = Color.FromArgb(78, 184, 206);
            email.ForeColor = Color.FromArgb(78, 184, 206);

            fpic.BackColor = Color.FromArgb(34, 36, 49);
            panelfirst.BackColor = Color.DarkSlateGray;
            fname.ForeColor = Color.DarkSlateGray;

            lpic.BackColor = Color.FromArgb(34, 36, 49);
            panellast.BackColor = Color.DarkSlateGray;
            lname.ForeColor = Color.DarkSlateGray;

            Username.BackColor = Color.FromArgb(34, 36, 49);
            paneluser.BackColor = Color.DarkSlateGray;
            Username.ForeColor = Color.DarkSlateGray;

            paspic.BackColor = Color.FromArgb(34, 36, 49);
            panelpass.BackColor = Color.DarkSlateGray;
            Password.ForeColor = Color.DarkSlateGray;

            Conpassword.BackColor = Color.FromArgb(34, 36, 49);
            panelconpas.BackColor = Color.DarkSlateGray;
            Conpassword.ForeColor = Color.DarkSlateGray;
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            Username.Clear();
            upic.BackColor = Color.FromArgb(78, 184, 206);
            paneluser.BackColor = Color.FromArgb(78, 184, 206);
            Username.ForeColor = Color.FromArgb(78, 184, 206);

            fpic.BackColor = Color.FromArgb(34, 36, 49);
            panelfirst.BackColor = Color.DarkSlateGray;
            fname.ForeColor = Color.DarkSlateGray;

            lpic.BackColor = Color.FromArgb(34, 36, 49);
            panellast.BackColor = Color.DarkSlateGray;
            lname.ForeColor = Color.DarkSlateGray;

            epic.BackColor = Color.FromArgb(34, 36, 49);
            panelemail.BackColor = Color.DarkSlateGray;
            email.ForeColor = Color.DarkSlateGray;

            paspic.BackColor = Color.FromArgb(34, 36, 49);
            panelpass.BackColor = Color.DarkSlateGray;
            Password.ForeColor = Color.DarkSlateGray;

            Conpassword.BackColor = Color.FromArgb(34, 36, 49);
            panelconpas.BackColor = Color.DarkSlateGray;
            Conpassword.ForeColor = Color.DarkSlateGray;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.Clear();
            Password.PasswordChar = '*';
            paspic.BackColor = Color.FromArgb(78, 184, 206);
            panelpass.BackColor = Color.FromArgb(78, 184, 206);
            Password.ForeColor = Color.FromArgb(78, 184, 206);

            fpic.BackColor = Color.FromArgb(34, 36, 49);
            panelfirst.BackColor = Color.DarkSlateGray;
            fname.ForeColor = Color.DarkSlateGray;

            lpic.BackColor = Color.FromArgb(34, 36, 49);
            panellast.BackColor = Color.DarkSlateGray;
            lname.ForeColor = Color.DarkSlateGray;

            epic.BackColor = Color.FromArgb(34, 36, 49);
            panelemail.BackColor = Color.DarkSlateGray;
            email.ForeColor = Color.DarkSlateGray;

            Username.BackColor = Color.FromArgb(34, 36, 49);
            paneluser.BackColor = Color.DarkSlateGray;
            Username.ForeColor = Color.DarkSlateGray;

            Conpassword.BackColor = Color.FromArgb(34, 36, 49);
            panelconpas.BackColor = Color.DarkSlateGray;
            Conpassword.ForeColor = Color.DarkSlateGray;
        }

        private void Conpassword_TextChanged(object sender, EventArgs e)
        {

            Conpassword.Clear();
            Conpassword.PasswordChar = '*';
            conpaspic.BackColor = Color.FromArgb(78, 184, 206);
            panelconpas.BackColor = Color.FromArgb(78, 184, 206);
            Conpassword.ForeColor = Color.FromArgb(78, 184, 206);

            fpic.BackColor = Color.FromArgb(34, 36, 49);
            panelfirst.BackColor = Color.DarkSlateGray;
            fname.ForeColor = Color.DarkSlateGray;

            lpic.BackColor = Color.FromArgb(34, 36, 49);
            panellast.BackColor = Color.DarkSlateGray;
            lname.ForeColor = Color.DarkSlateGray;

            epic.BackColor = Color.FromArgb(34, 36, 49);
            panelemail.BackColor = Color.DarkSlateGray;
            email.ForeColor = Color.DarkSlateGray;

            Username.BackColor = Color.FromArgb(34, 36, 49);
            paneluser.BackColor = Color.DarkSlateGray;
            Username.ForeColor = Color.DarkSlateGray;

            paspic.BackColor = Color.FromArgb(34, 36, 49);
            panelpass.BackColor = Color.DarkSlateGray;
            Password.ForeColor = Color.DarkSlateGray;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            SIgnup signup = new SIgnup();
            bunifuTransition1.HideSync(signup);
            bunifuTransition1.ShowSync(login);
            this.Close();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
    }    
}
