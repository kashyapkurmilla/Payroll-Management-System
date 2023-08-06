using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payrollmanagementsystem
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            //this.Hide();
            frm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            //this.Hide();
            frm.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Logged Out Successfully");
        }
    }
}
