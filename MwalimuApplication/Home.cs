using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace MwalimuApplication
{
    public partial class Home : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private string filepath;
        
        public Home()
        {
            InitializeComponent();
            string WorkingDirectory = Application.StartupPath + "\\";
            connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+WorkingDirectory+"DataStudent.accdb; Persist Security Info=False";
            
        }

        private void BunifuTileButton1_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";

               if (dialog.ShowDialog() == DialogResult.OK)
               {
                    string imageLocation = dialog.FileName; 
                    pictureBox1.ImageLocation = imageLocation;
                    string source = dialog.FileName;
                    string dest = Application.StartupPath + "\\Images\\" + Path.GetFileName(source);
                    File.Copy(source, dest);
                    filepath = dest;
               }
               else
               {
                    MessageBox.Show("Photo Saving Failed successfully");
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

          
        }
        private byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, format);
            return memoryStream.ToArray();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.ImageLocation = filepath;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }
    }
    
}
