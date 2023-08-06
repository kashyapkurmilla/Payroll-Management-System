using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace payrollmanagementsystem
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
            setConnection();
        }
        public void setConnection()
        {
            conn = new OracleConnection("DATA SOURCE=localhost:1521/orcl;PERSIST SECURITY INFO=True;USER ID=KASHYAP;PASSWORD=kurmilla2004");
            try
            {
                conn.Open();
            } 
            catch(Exception e)
            {
                MessageBox.Show("not Connected");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            //this.Hide();
            frm.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
