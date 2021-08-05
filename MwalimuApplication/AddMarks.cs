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
    public partial class AddMarks : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public AddMarks()
        {
            InitializeComponent();
            string WorkingDirectory = Application.StartupPath + "\\";
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + WorkingDirectory + "DataStudent.accdb; Persist Security Info=False";
         
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Term1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Term1Marks ([AdmissionNumber],[Mathematics],[English],[Kiswahili],[Science],[SST/RE],[Total],[Average],[Grade]) values('" + bunifuMaterialTextbox9.Text + "','" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextbox4.Text + "','" + bunifuMaterialTextbox5.Text + "','" + bunifuMaterialTextbox7.Text + "','" + bunifuMaterialTextbox6.Text + "','" + bunifuMaterialTextbox8.Text + "')";
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

        private void Term2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Term2Marks ([AdmissionNumber],[Mathematics],[English],[Kiswahili],[Science],[SST/RE],[Total],[Average],[Grade]) values('" + bunifuMaterialTextbox9.Text + "','" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextbox4.Text + "','" + bunifuMaterialTextbox5.Text + "','" + bunifuMaterialTextbox7.Text + "','" + bunifuMaterialTextbox6.Text + "','" + bunifuMaterialTextbox8.Text + "')";
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

        private void Term3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Term3Marks ([AdmissionNumber],[Mathematics],[English],[Kiswahili],[Science],[SST/RE],[Total],[Average],[Grade]) values('" + bunifuMaterialTextbox9.Text + "','" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox2.Text + "','" + bunifuMaterialTextbox3.Text + "','" + bunifuMaterialTextbox4.Text + "','" + bunifuMaterialTextbox5.Text + "','" + bunifuMaterialTextbox7.Text + "','" + bunifuMaterialTextbox6.Text + "','" + bunifuMaterialTextbox8.Text + "')";
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
    }
    
}
