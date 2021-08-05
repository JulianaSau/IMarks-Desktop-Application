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
    public partial class ExitMessage : Form
    {
        
        public ExitMessage()
        {
            InitializeComponent();
           
        }

        private void SuccessMessage_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }

       

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
