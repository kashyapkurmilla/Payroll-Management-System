using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace payrollmanagementsystem
{
    public partial class Form7 : Form
    {
        public string StdName2 { get; set; }
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.StdName3 = StdName2;
           // this.Hide();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.StdName21 = StdName2;
            frm.ShowDialog();
           // this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Logged Out Successfully");
        }
    }
}
