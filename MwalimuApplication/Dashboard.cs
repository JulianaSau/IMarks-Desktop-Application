using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialIcons;
using BunifuAnimatorNS;
using Bunifu;

namespace MwalimuApplication
{
    public partial class Dashboard : Form
    {
        public Dashboard(string username)
        {
            
            InitializeComponent();
            label3.Text = "Welcome back " + username;
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
            panel2.Visible = false;
            
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            AddOwnedForm(addStudent);
            addStudent.FormBorderStyle = FormBorderStyle.None;
            addStudent.TopLevel = false;
            addStudent.Dock =DockStyle.Right ;
            this.Controls.Add(addStudent);
            this.Tag = addStudent;
            addStudent.BringToFront();
            addStudent.Show(); 
        }

        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            ViewData viewData = new ViewData();
            AddOwnedForm(viewData);
            viewData.FormBorderStyle = FormBorderStyle.None;
            viewData.TopLevel = false;
            viewData.Dock = DockStyle.Right;
            this.Controls.Add(viewData);
            this.Tag = viewData;
            viewData.BringToFront();
            viewData.Show();
        }

        private void MaterialFlatButton3_Click(object sender, EventArgs e)
        {
            
            AddMarks addMarks = new AddMarks();
            AddOwnedForm(addMarks);
            addMarks.FormBorderStyle = FormBorderStyle.None;
            addMarks.TopLevel = false;
            addMarks.Dock = DockStyle.Right;
            this.Controls.Add(addMarks);
            this.Tag = addMarks;
            addMarks.BringToFront();
            addMarks.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

            ExitMessage exit = new ExitMessage();
            exit.ShowDialog();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (panel3.Width == 57 && panel2.Width==57)
            {
                panel3.Visible = false;
                panel2.Visible = false;
                panel3.Width = 211;
                panel2.Width = 211;
                bunifuTransition1.ShowSync(panel3);
                bunifuTransition1.ShowSync(panel2);
                bunifuTransition2.ShowSync(label4);
                

            }
            else
            {
                
                bunifuTransition2.Hide(label4);
                bunifuTransition2.ShowSync(pictureBox2);
                panel3.Visible = false;
                panel2.Visible = false;
                panel2.Width =57;
                panel3.Width =57;
                bunifuTransition1.ShowSync(panel3);
                
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AddOwnedForm(home);
            home.FormBorderStyle = FormBorderStyle.None;
            home.TopLevel = false;
            home.Dock = DockStyle.Right;
            this.Controls.Add(home);
            this.Tag = home;
            home.BringToFront();
            home.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void PictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(9, 98, 212);
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.FromArgb(25, 32, 39);
        }

        private void PictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(9, 98, 212);
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.FromArgb(25, 32, 39);
        }

        private void PictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.FromArgb(9, 98, 212);
        }

        private void PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.FromArgb(25, 32, 39);
        }

        private void PictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.FromArgb(9, 98, 212);
        }

        private void PictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.FromArgb(25, 32, 39);
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.FromArgb(9, 98, 212);
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.FromArgb(25, 32, 39);
        }

        private void Editstudent_Click(object sender, EventArgs e)
        {
            EditStudentData editStudentData = new EditStudentData();
            AddOwnedForm(editStudentData);
            editStudentData.FormBorderStyle = FormBorderStyle.None;
            editStudentData.TopLevel = false;
            editStudentData.Dock = DockStyle.Right;
            this.Controls.Add(editStudentData);
            this.Tag = editStudentData;
            editStudentData.BringToFront();
            editStudentData.Show();
        }

        private void Editmarks_Click(object sender, EventArgs e)
        {
            EditMarks editMarks = new EditMarks();
            AddOwnedForm(editMarks);
            editMarks.FormBorderStyle = FormBorderStyle.None;
            editMarks.TopLevel = false;
            editMarks.Dock = DockStyle.Right;
            this.Controls.Add(editMarks);
            this.Tag = editMarks;
            editMarks.BringToFront();
            editMarks.Show();
        }

        private void Viewstudents_Click(object sender, EventArgs e)
        {
            Student_List student_List = new Student_List();
            AddOwnedForm(student_List);
            student_List.FormBorderStyle = FormBorderStyle.None;
            student_List.TopLevel = false;
            student_List.Dock = DockStyle.Right;
            this.Controls.Add(student_List);
            this.Tag = student_List;
            student_List.BringToFront();
            student_List.Show();
        }

        private void Viewmarklist_Click(object sender, EventArgs e)
        {
            
            View_Marklist view_Marklist = new View_Marklist();
            AddOwnedForm(view_Marklist);
            view_Marklist.FormBorderStyle = FormBorderStyle.None;
            view_Marklist.TopLevel = false;
            view_Marklist.Dock = DockStyle.Right;
            this.Controls.Add(view_Marklist);
            this.Tag = view_Marklist;
            view_Marklist.BringToFront();
            view_Marklist.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
            
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            AddOwnedForm(home);
            home.FormBorderStyle = FormBorderStyle.None;
            home.TopLevel = false;
            home.Dock = DockStyle.Right;
            this.Controls.Add(home);
            this.Tag = home;
            home.BringToFront();
            home.Show();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            ExitMessage exit = new ExitMessage();
            exit.ShowDialog();
        }
    }
}
